create database University;
use University;

create table if not exists faculty(
	FacID int not null,
    Fac_Name varchar(255) not  null,
    primary key(FacID)
);

create table if not exists lecturer(
	Lecturer_ID int not null,
    Full_Name varchar(255) not null,
    FacID int not null,
    primary key(Lecturer_ID),
    foreign key(FacID)
    references faculty (FacID)
    on delete restrict
    on update cascade
);

create table if not exists student(
	Student_ID int not null,
	Full_Name varchar(255) not null,
    Date_of_birth date,
    Gender varchar(1) default null,
    current_status varchar(10) default null,
    FacID int not null,
    primary key(Student_ID),
    foreign key(FacID)
    references faculty(FacID)
    on delete restrict
    on update cascade
);

create table if not exists subject(
	SubID varchar(6) not null,
    Subject_Name varchar(255) not null,
    Num_Credit int not null check(Num_Credit > 0 and Num_Credit <= 4),
    Semester int not null,
    FacID int not null,
    primary key(SubID, Semester),
    foreign key(FacID)
    references faculty(FacID)
    on delete restrict
    on update cascade
);

create table if not exists class(
	Class_Name varchar(4) not null,
    SubID varchar(6) not null,
    Semester int not null,
    primary key(Class_Name, SubID, Semester),
    foreign key(SubID, Semester)
    references subject(SubID, Semester)
);

create table if not exists publisher(
	Publisher_ID INT NOT NULL,
	Publisher_Name VARCHAR(255) NOT NULL,
	Domestic_Flag TINYINT NULL,
	primary key(Publisher_ID)
);

create table if not exists textbook(
	TextBook_ID INT NOT NULL,
	TextBook_Name VARCHAR(255) NOT NULL,
	specialization VARCHAR(255) NOT NULL,
	PRIMARY KEY (TextBook_ID)
);

create table if not exists author(
	`Author_ID` INT NOT NULL,
	`Author_Name` VARCHAR(255) NOT NULL,
	PRIMARY KEY (`Author_ID`)
);

create table if not exists register(
	SubID varchar(6) NOT NULL,
	Student_ID INT NOT NULL,
	Semester INT NOT NULL,
    FOREIGN KEY (`SubID`)
    REFERENCES Subject (SubID)
    on delete restrict
    on update cascade,
    FOREIGN KEY (`Student_ID`)
    REFERENCES `University`.`Student` (`Student_ID`)
    on delete restrict
    on update cascade,
    FOREIGN KEY (`Semester`)
    REFERENCES `University`.`Subject` (`Semester`)
    on delete restrict
    on update cascade
);

create table if not exists manage_point(
	`Class_Name` VARCHAR(4) NOT NULL,
	`Semester` INT NOT NULL,
	`SubID` varchar(6) NOT NULL,
	`Student_ID` INT NOT NULL,
	`Lecturer_ID` INT NOT NULL,
	`Summary_Point` FLOAT,
    FOREIGN KEY (`Class_Name`)
    REFERENCES `University`.`Class` (`Class_Name`)
    on delete restrict
    on update cascade,
    FOREIGN KEY (`Semester`)
    REFERENCES `University`.`Class` (`Semester`)
    on delete restrict
    on update cascade,
    FOREIGN KEY (`SubID`)
    REFERENCES `University`.`Subject` (`Semester`)
    on delete restrict
    on update cascade,
    FOREIGN KEY (`Student_ID`)
    REFERENCES `University`.`Student` (`Student_ID`)
    on delete restrict
    on update cascade
);

create table if not exists manage_subject(
	`TextBook_ID` INT NOT NULL,
	`Semester` INT NOT NULL,
	`SubID` varchar(6) NOT NULL,
	`Lecturer_ID` INT NOT NULL,
    FOREIGN KEY (`TextBook_ID`)
    REFERENCES `University`.`Textbook` (`TextBook_ID`)
    on delete restrict
    on update cascade,
    FOREIGN KEY (`SubID`)
    REFERENCES `University`.`Subject` (`SubID`)
    on delete restrict
    on update cascade,
    FOREIGN KEY (`Semester`)
    REFERENCES `University`.`Subject` (`Semester`)
    on delete restrict
    on update cascade
);

create table if not exists compile(
	`TextBook_ID` INT NOT NULL,
	`Author_ID` INT NOT NULL,
    FOREIGN KEY (`TextBook_ID`)
    REFERENCES `University`.`Textbook` (`TextBook_ID`)
	on delete restrict
    on update cascade,
    FOREIGN KEY (`Author_ID`)
    REFERENCES `University`.`Author` (`Author_ID`)
    on delete restrict
    on update cascade
);

create table if not exists publish(
	`Publisher_ID` INT NOT NULL,
	`TextBook_ID` INT NOT NULL,
    FOREIGN KEY (`Publisher_ID`)
    REFERENCES `University`.`Publisher` (`Publisher_ID`)
    on delete restrict
    on update cascade,
    FOREIGN KEY (`TextBook_ID`)
    REFERENCES `University`.`Textbook` (`TextBook_ID`)
    on delete restrict
    on update cascade
);

create table if not exists teach(
	`Class_Name` VARCHAR(4) NOT NULL,
	`Semester` INT NOT NULL,
	`SubID` varchar(6) NOT NULL,
	`Lecturer_ID` INT NOT NULL,
    FOREIGN KEY (`Lecturer_ID`)
    REFERENCES `University`.`Lecturer` (`Lecturer_ID`)
    on delete restrict
    on update cascade,
    FOREIGN KEY (`SubID`)
    REFERENCES `University`.`Class` (`Semester`)
    on delete restrict
    on update cascade,
     FOREIGN KEY (`Class_Name`)
    REFERENCES `University`.`Class` (`Class_Name`)
	on delete restrict
    on update cascade,
     FOREIGN KEY (`Semester`)
    REFERENCES `University`.`Class` (`Semester`)
    on delete restrict
    on update cascade
);

CREATE USER 'student'@'localhost' IDENTIFIED BY 'student';
CREATE USER 'faculty'@'localhost' IDENTIFIED BY 'faculty';
CREATE USER 'lecturer'@'localhost' IDENTIFIED BY 'lecturer';
-- Creating Roles on 
-- student 

GRANT SELECT on university.student to 'student';
GRANT SELECT on university.lecturer to 'student';
GRANT SELECT on university.faculty to 'student';
GRANT SELECT , INSERT , UPDATE on university.register to 'student';
GRANT SELECT on university.subject to 'student';
-- Grant lecturer
GRANT INSERT , UPDATE, SELECT ON university.textbook to 'lecturer ';
GRANT SELECT , INSERT , UPDATE , DELETE ON university.manage_point to 'lecturer 
';
GRANT SELECT ON university.register to 'lecturer ';
GRANT SELECT ON university.class to 'lecturer ';
GRANT SELECT ON university.faculty to 'lecturer ';










