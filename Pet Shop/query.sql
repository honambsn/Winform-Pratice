create database VeterinaryDb 
go
use VeterinaryDb
go
create table Pet
(
  Pet_Id int identity (100000,1) primary key,
  Pet_Name nvarchar (50) not null,
  Pet_Type nvarchar (50) not null,
  Pet_Colour nvarchar (50) not null,
  Pet_Breed nvarchar (50) not null
)
go
insert into Pet values('Buttons', 'Dog', 'White')
insert into Pet values('Coda', 'Cat', 'Multicolor')
insert into Pet values('Merlin', 'Parrot', 'Green-Yellow')
insert into Pet values('Nina', 'Turtle', 'Dark Gray')
insert into Pet values('Domino', 'Rabbit', 'White')
insert into Pet values('Luna', 'Hamster', 'Orange')
insert into Pet values('Lucy', 'Monkey', 'Brown')
insert into Pet values('Daysi', 'Horse', 'White')
insert into Pet values('Zoe', 'Snake', 'Yellow white')
insert into Pet values('Max', 'Budgie', 'Yellow')
insert into Pet values('Charlie', 'Mouse', 'White')
insert into Pet values('Rocky', 'Squirrel', 'Brown-Orange')
insert into Pet values('Leo', 'Dog', 'White-Black')
insert into Pet values('Loki', 'Cat', 'Black')
insert into Pet values('Jasper', 'Dog', 'Silver')

-- Insert additional pet records into the Pet table
INSERT INTO Pet VALUES ('Bella', 'Dog', 'Black');
INSERT INTO Pet VALUES ('Oliver', 'Cat', 'Gray');
INSERT INTO Pet VALUES ('Ruby', 'Parrot', 'Red');
INSERT INTO Pet VALUES ('Toby', 'Turtle', 'Green');
INSERT INTO Pet VALUES ('Shadow', 'Rabbit', 'Gray');
INSERT INTO Pet VALUES ('Milo', 'Hamster', 'White');
INSERT INTO Pet VALUES ('Maggie', 'Monkey', 'Gray');
INSERT INTO Pet VALUES ('Coco', 'Horse', 'Brown');
INSERT INTO Pet VALUES ('Nala', 'Snake', 'Green');
INSERT INTO Pet VALUES ('Buddy', 'Budgie', 'Blue');
INSERT INTO Pet VALUES ('Sophie', 'Mouse', 'Gray');
INSERT INTO Pet VALUES ('Sam', 'Squirrel', 'Gray-White');
INSERT INTO Pet VALUES ('Chloe', 'Dog', 'Brindle');
INSERT INTO Pet VALUES ('Lily', 'Cat', 'Cream');
INSERT INTO Pet VALUES ('Rex', 'Dog', 'Red');
INSERT INTO Pet VALUES ('Ginger', 'Parrot', 'Orange');
INSERT INTO Pet VALUES ('Whiskers', 'Turtle', 'Brown');
INSERT INTO Pet VALUES ('Pebbles', 'Rabbit', 'Brown');
INSERT INTO Pet VALUES ('Gizmo', 'Hamster', 'Black');
INSERT INTO Pet VALUES ('Sandy', 'Monkey', 'Tan');
INSERT INTO Pet VALUES ('Juno', 'Horse', 'Gray');
INSERT INTO Pet VALUES ('Misty', 'Snake', 'Blue');
INSERT INTO Pet VALUES ('Skye', 'Budgie', 'Green');
INSERT INTO Pet VALUES ('Tinker', 'Mouse', 'Brown');
INSERT INTO Pet VALUES ('Twilight', 'Squirrel', 'Black');


insert into Pet values('Bella', 'Dog', 'Golden');
insert into Pet values('Whiskers', 'Cat', 'Gray');
insert into Pet values('Sunny', 'Parrot', 'Yellow-Green');
insert into Pet values('Shelly', 'Turtle', 'Light Green');
insert into Pet values('Thumper', 'Rabbit', 'Gray');
insert into Pet values('Gizmo', 'Hamster', 'White-Brown');
insert into Pet values('Milo', 'Monkey', 'Black-White');
insert into Pet values('Spirit', 'Horse', 'Chestnut');
insert into Pet values('Stripe', 'Snake', 'Green-Black');
insert into Pet values('Kiwi', 'Budgie', 'Green');
insert into Pet values('Nibbles', 'Mouse', 'Brown');
insert into Pet values('Acorn', 'Squirrel', 'Gray-Brown');
insert into Pet values('Rocky', 'Dog', 'Brindle');
insert into Pet values('Shadow', 'Cat', 'Black-White');
insert into Pet values('Oliver', 'Dog', 'Golden-Retired');
insert into Pet values('Penny', 'Turtle', 'Olive');
insert into Pet values('Ziggy', 'Parrot', 'Blue');
insert into Pet values('Fluffy', 'Rabbit', 'White-Brown');
insert into Pet values('Coco', 'Hamster', 'Chocolate');
insert into Pet values('Dexter', 'Monkey', 'Gray');
insert into Pet values('Tango', 'Horse', 'Bay');

insert into Pet values('Rex', 'Dog', 'Tan');
insert into Pet values('Smokey', 'Cat', 'Silver-Gray');
insert into Pet values('Peppy', 'Parrot', 'Red-Green');
insert into Pet values('Tina', 'Turtle', 'Brown');
insert into Pet values('Bunny', 'Rabbit', 'Black-White');
insert into Pet values('Pippin', 'Hamster', 'Gold');
insert into Pet values('Chester', 'Monkey', 'Brown-Black');
insert into Pet values('Dancer', 'Horse', 'Pinto');
insert into Pet values('Ginger', 'Snake', 'Red-Orange');
insert into Pet values('Bubbles', 'Budgie', 'Blue');
insert into Pet values('Cheddar', 'Mouse', 'Yellow');
insert into Pet values('Nutmeg', 'Squirrel', 'Brown-White');
insert into Pet values('Bruno', 'Dog', 'Chocolate');
insert into Pet values('Salem', 'Cat', 'Black');
insert into Pet values('Rusty', 'Dog', 'Rust');
insert into Pet values('Flora', 'Turtle', 'Light Blue');
insert into Pet values('Sunny', 'Parrot', 'Yellow-Blue');
insert into Pet values('Snowball', 'Rabbit', 'Fluffy White');
insert into Pet values('Pepper', 'Hamster', 'Black');
insert into Pet values('Gizmo', 'Monkey', 'Cream');
insert into Pet values('Nemo', 'Fish', 'Orange-White');
insert into Pet values('Taffy', 'Horse', 'Dapple Gray');
insert into Pet values('Spike', 'Snake', 'Brown-Gray');
insert into Pet values('Echo', 'Budgie', 'Turquoise');
insert into Pet values('Mochi', 'Mouse', 'Gray-White');
insert into Pet values('Almond', 'Squirrel', 'Cream');
insert into Pet values('Tank', 'Dog', 'Black-Tan');
insert into Pet values('Luna', 'Cat', 'White-Gray');
insert into Pet values('Bolt', 'Dog', 'Black-Brown');
insert into Pet values('Lilly', 'Turtle', 'Pink');
insert into Pet values('Zara', 'Parrot', 'Orange-Yellow');
insert into Pet values('Dusty', 'Rabbit', 'Light Gray');
insert into Pet values('Fudge', 'Hamster', 'Chocolate-Brown');

insert into Pet values('Kara', 'Dog', 'Golden');
insert into Pet values('Kiki', 'Cat', 'Gray-White');
insert into Pet values('Karma', 'Parrot', 'Red-Green');
insert into Pet values('Kona', 'Turtle', 'Light Green');
insert into Pet values('Kiki', 'Rabbit', 'Black');
insert into Pet values('Koda', 'Hamster', 'Cream');
insert into Pet values('Kash', 'Monkey', 'Brown-Black');
insert into Pet values('Kylie', 'Horse', 'Palomino');
insert into Pet values('Kora', 'Snake', 'Green');
insert into Pet values('Kiki', 'Budgie', 'Turquoise');
insert into Pet values('Kobe', 'Mouse', 'Black');
insert into Pet values('Kara', 'Squirrel', 'Brown');
insert into Pet values('Koda', 'Dog', 'White-Brown');
insert into Pet values('Kiki', 'Cat', 'Black-Gray');
insert into Pet values('Kurt', 'Dog', 'Brindle');
insert into Pet values('Kali', 'Turtle', 'Yellow');
insert into Pet values('Kylie', 'Parrot', 'Blue');
insert into Pet values('Kora', 'Rabbit', 'Gray-White');
insert into Pet values('Karma', 'Hamster', 'Orange');
insert into Pet values('Kirk', 'Monkey', 'Gold');
insert into Pet values('Kestrel', 'Horse', 'Chestnut');

insert into Pet values('Akira', 'Dog', 'Black');
insert into Pet values('Aksel', 'Cat', 'Tabby');
insert into Pet values('Akemi', 'Parrot', 'Blue');
insert into Pet values('Akira', 'Turtle', 'Green');
insert into Pet values('Akito', 'Rabbit', 'White');
insert into Pet values('Akira', 'Hamster', 'Golden');
insert into Pet values('Akhil', 'Monkey', 'Brown');
insert into Pet values('Akasha', 'Horse', 'Pinto');
insert into Pet values('Akuma', 'Snake', 'Black-White');
insert into Pet values('Akira', 'Budgie', 'Yellow-Green');


go


select * from Pet order by Pet_Id asc
SELECT * FROM Pet where Pet_Id=100011 or Pet_Name like 'Loki'+'%' order by Pet_Id asc

ALTER TABLE Pet
ADD Pet_Breed VARCHAR(255) DEFAULT 'Unknown';

alter table Pet
drop column Pet_Breed


ALTER TABLE Pet
DROP CONSTRAINT DF__Pet__Pet_Breed__36B12243;
