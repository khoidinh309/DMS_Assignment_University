DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `add_new_student_of_class`(class_name varchar(4), semester int, subID varchar(6), student_ID int)
BEGIN
	insert into manage_point(class_name,semester,subID,student_ID)
    values(class_name,semester,subID,student_ID);
END;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `add_new_textbook`(lecturer_id int, subID varchar(6), textbook_name varchar(255),specialization varchar(255))
BEGIN
    insert into textbook(TextBook_Name,specialization)
	values(textbook_name, specialization);
	
	update manage_subject
    set textbook_id = textbook.textbook_id
    where manage_subject.subID = subID and manage_subject.lecturer_id = lecturer_id and textbook.textbook_name = textbook_name and textbook.specialization = specialization;
END;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `canncel_registered_class`(student_id int, subID varchar(6), class_name varchar(4), semester int)
BEGIN
	delete from manage_point
    where manage_point.student_id = student_id and manage_point.subID = subID and manage_point.class_name = class_name and manage_point.semester = semester;
	delete from register
    where register.student_id = student_id and register.subID = subID and register.semester = semester;
END;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `get_class_list`()
begin
select c.class_name as Lop,s.subID as Subject_ID,s.subject_name as Ten_Mon_Hoc, s.num_credit as so_tin_chi, s.semester
from subject s, class c
where s.subid = c.subid;
end;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `get_class_list_by_id`(input varchar(45))
BEGIN
	select c.class_name as Lop,s.subID as Subject_ID,s.subject_name as Ten_Mon_Hoc, s.num_credit as so_tin_chi, s.semester
	from subject s, class c
    where s.subid = c.subid and (s.subid = input or s.subject_name = input);
END;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `get_lecturer_id`(class_name varchar(4), subID varchar(6))
BEGIN
	select lecturer_id
    from teach as t
    where t.class_name = class_name and t.subID = subID;
END;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `get_not_managed_class`(faculty_id int)
BEGIN
	select c.class_name, c.subID, s.subject_name, s.semester, s.num_credit
    from class as c, subject as s
    where not exists (select *
						from teach as t
                        where t.subID = c.subID and t.class_name = c.class_name)
		 and c.subID = s.subID and faculty_id = s.facID;
END;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `get_number_member`(subID varchar(6), class_name varchar(4))
BEGIN
	select count(student_ID)
    from manage_point as p
    where p.subID = subID and p.class_name = class_name;
END;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `get_registered_class`(student_ID int)
BEGIN
	select m.class_name,m.subID, s.subject_name,m.semester,s.num_credit
    from manage_point as m, subject as s
    where m.student_id = student_ID and m.subID = s.subID;
END;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `get_released_subject_list`(faculty_id int)
BEGIN
	select s.subID, s.subject_name, s.num_credit, s.semester
    from subject as s
    where s.facID = faculty_id and exists (select * from class as c where c.subID = s.subID);
END;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `get_student_list`(subID varchar(6), class_name varchar(4))
BEGIN
	select m.student_id, full_name, summary_point
    from manage_point as m, student as s
    where m.subID = subID and m.class_name = class_name and m.student_ID = s.student_ID;
END;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `get_teaching_class`(lecturer_id int)
BEGIN
	select class_name,t.subID,s.subject_name,t.semester,s.num_credit
    from teach as t, subject as s
    where t.lecturer_ID = lecturer_Id and t.subID = s.subID;
END
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `get_textbook_list`(subID varchar(6))
BEGIN
	select m.textbook_id, t.textbook_name, t.specialization
    from manage_subject as m, textbook as t
    where m.subID = subID and m.textbook_id = t.textbook_id;
END
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `get_unreleased_subject`(faculty_id int)
BEGIN
	select s.subID, s.subject_name, s.num_credit, s.semester
    from subject as s
    where s.facID = faculty_id and not exists (select * from class as c where c.subID = s.subID);
END;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `released_new_subject`(subID varchar(6))
BEGIN
	insert into class
    values("L01",subID,221),
    ("L02",subID,221),
    ("L03",subID,221);
END;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `released_new_subject`(subID varchar(6))
BEGIN
	insert into class
    values("L01",subID,221),
    ("L02",subID,221),
    ("L03",subID,221);
END;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `set_mark_to_student`(class_name varchar(4), subID varchar(6),student_id int, mark float)
BEGIN
	update manage_point
    set manage_point.Summary_Point = mark
    where manage_point.class_name = class_name and manage_point.subID = subID and manage_point.student_ID = student_id;
END;
DELIMITER //

DELIMITER //
CREATE DEFINER=`khoidinh309`@`localhost` PROCEDURE `set_work_lecturer`(class_name varchar(4), subID varchar(6), semester int, lecturer_ID int)
BEGIN
	declare exit handler for sqlexception rollback;
    start transaction;
	insert into teach
    values(class_name,semester,subID,lecturer_ID);
    
    update manage_point set manage_point.lecturer_ID = lecturer_ID 
    where manage_point.class_name = class_name and manage_point.subID = subID;
    
    insert into manage_subject(subID,lecturer_id,semester)
    values (subID,lecturer_ID,semester);
    commit;
END;
DELIMITER //