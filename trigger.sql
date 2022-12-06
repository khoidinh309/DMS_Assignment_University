delimiter //
create trigger add_item_register_table 
after insert on manage_point for each row
begin
	insert into register(subID,student_ID,semester)
    values(new.subID, new.student_ID,new.semester);
end;
delimiter //

delimiter //
create trigger set_null_after_remove_lecturer
after delete on teach for each row
begin
	update manage_point
    set lecturer_id = null
    where lecturer_id = old.lecturer_id and class_name = old.class_name and subID = old.subID;
    
    delete from manage_subject
    where lecturer_id = old.lecturer_id and class_name = old.class_name and subID = old.subID;
end;
delimiter //