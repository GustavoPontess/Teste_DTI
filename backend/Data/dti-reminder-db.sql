CREATE DATABASE dtiReminderDB;

USE dtiReminderDB;

CREATE TABLE reminder (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    date DATE NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP,
    deleted_at TIMESTAMP,
    is_deleted TINYINT NOT NULL DEFAULT 0
);

INSERT INTO reminder (name, date) VALUES ('Meeting 1', '2023-07-28');
INSERT INTO reminder (name, date) VALUES ('Doctor Appointment 1', '2023-08-05');
INSERT INTO reminder (name, date) VALUES ('Buy Groceries 1', '2023-07-30');
INSERT INTO reminder (name, date) VALUES ('Submit Report 1', '2023-08-10');
INSERT INTO reminder (name, date) VALUES ('Call Mom 1', '2023-07-29');
INSERT INTO reminder (name, date) VALUES ('Dentist Appointment 1', '2023-08-05');
INSERT INTO reminder (name, date) VALUES ('Meeting 2', '2023-07-31');
INSERT INTO reminder (name, date) VALUES ('Doctor Appointment 2', '2023-08-07');
INSERT INTO reminder (name, date) VALUES ('Buy Groceries 2', '2023-07-30');
INSERT INTO reminder (name, date) VALUES ('Submit Report 2', '2023-08-12');
INSERT INTO reminder (name, date) VALUES ('Call Mom 2', '2023-07-29');
INSERT INTO reminder (name, date) VALUES ('Dentist Appointment 2', '2023-08-05');
INSERT INTO reminder (name, date) VALUES ('Meeting 3', '2023-07-30');
INSERT INTO reminder (name, date) VALUES ('Doctor Appointment 3', '2023-08-07');
INSERT INTO reminder (name, date) VALUES ('Buy Groceries 3', '2023-07-30');
INSERT INTO reminder (name, date) VALUES ('Submit Report 3', '2023-08-12');
INSERT INTO reminder (name, date) VALUES ('Call Mom 3', '2023-07-29');
INSERT INTO reminder (name, date) VALUES ('Dentist Appointment 3', '2023-08-06');
INSERT INTO reminder (name, date) VALUES ('Meeting 4', '2023-07-30');
INSERT INTO reminder (name, date) VALUES ('Doctor Appointment 4', '2023-08-07');
INSERT INTO reminder (name, date) VALUES ('Buy Groceries 4', '2023-07-30');
INSERT INTO reminder (name, date) VALUES ('Submit Report 4', '2023-08-12');
INSERT INTO reminder (name, date) VALUES ('Call Mom 4', '2023-07-29');
INSERT INTO reminder (name, date) VALUES ('Dentist Appointment 4', '2023-08-05');
INSERT INTO reminder (name, date) VALUES ('Meeting 5', '2023-07-31');
INSERT INTO reminder (name, date) VALUES ('Doctor Appointment 5', '2023-08-07');
INSERT INTO reminder (name, date) VALUES ('Buy Groceries 5', '2023-07-30');
INSERT INTO reminder (name, date) VALUES ('Submit Report 5', '2023-08-12');
INSERT INTO reminder (name, date) VALUES ('Call Mom 5', '2023-07-29');
INSERT INTO reminder (name, date) VALUES ('Meeting', '2023-07-28');
INSERT INTO reminder (name, date) VALUES ('Doctor Appointment', '2023-08-05');
INSERT INTO reminder (name, date) VALUES ('Buy Groceries', '2023-07-30');
INSERT INTO reminder (name, date) VALUES ('Submit Report', '2023-08-10');
INSERT INTO reminder (name, date) VALUES ('Call Mom', '2023-07-29');
INSERT INTO reminder (name, date) VALUES ('Dentist Appointment', '2023-08-05');
INSERT INTO reminder (name, date) VALUES ('Dentist Appointment 5', '2023-08-06');

