--Could use EF seed insert when migrating but for testing
--easier to use sql


--relationship inserts
insert into EmployeeRelationships values(1,2,1)
insert into EmployeeRelationships values(1,3,2)
insert into EmployeeRelationships values(1,4,2)
insert into EmployeeRelationships values(2,6,2)
insert into EmployeeRelationships values(3,8,2)
insert into EmployeeRelationships values(3,9,2)


--employee inserts
insert into employees values(1,1)
insert into employees values(2,5)
insert into employees values(3,7)
insert into employees values(4,10)
insert into employees values(5,11)

--People inserts
--family 1
--employee
insert into People values ('John', 'Doe')
--spouse
insert into People values ('Jane', 'Doe')
--dependants
insert into People values ('Jodi', 'Doe')
insert into People values ('Iyla', 'Doe')
--family 2
--employee
insert into People values ('Sarah', 'Smith')
--dependant
insert into People values ('Wyatt', 'Smith')
--family three
--employee
insert into People values ('Scott', 'Brooks')
--dependants
insert into People values ('Jackson', 'Brooks')
insert into People values ('Aaron', 'Brooks')
--family 4
--employee
insert into People values ('Matt', 'Bennett')
--family 5
--employee
insert into People values ('Elliot', 'Thomas')

