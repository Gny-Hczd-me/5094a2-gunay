"""Database layer: yalnız SQL Server ilə əlaqəli funksiyalar."""

from contextlib import closing

import pymssql

from config import load_database_settings


def create_connection():
    settings = load_database_settings()
    return pymssql.connect(
        server=settings["server"],
        user=settings["user"],
        password=settings["password"],
        database=settings["database"],
    )


def add_student(student_name, student_score):
    with closing(create_connection()) as connection:
        cursor = connection.cursor()
        cursor.execute(
            "INSERT INTO Students (Name, Score) VALUES (%s, %s)",
            (student_name, student_score),
        )
        connection.commit()


def get_students():
    with closing(create_connection()) as connection:
        cursor = connection.cursor()
        cursor.execute("SELECT Name, Score FROM Students ORDER BY Id")
        return cursor.fetchall()


def get_student(search_text):
    with closing(create_connection()) as connection:
        cursor = connection.cursor()
        cursor.execute(
            "SELECT Name, Score FROM Students WHERE Name LIKE %s ORDER BY Id",
            (f"%{search_text}%",),
        )
        return cursor.fetchall()
