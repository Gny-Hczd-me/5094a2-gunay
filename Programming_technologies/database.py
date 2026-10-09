"""Database layer: yalnız SQL Server ilə əlaqəli funksiyalar."""

import pyodbc

from config import DB_DRIVER, DB_NAME, DB_SERVER


def create_connection():
    connection_string = (
        f"DRIVER={{{DB_DRIVER}}};"
        f"SERVER={DB_SERVER};"
        f"DATABASE={DB_NAME};"
        "Trusted_Connection=yes;"
        "TrustServerCertificate=yes;"
    )
    return pyodbc.connect(connection_string)


def add_student(student_name, student_score):
    with create_connection() as connection:
        cursor = connection.cursor()
        cursor.execute(
            "INSERT INTO Students (Name, Score) VALUES (?, ?)",
            student_name,
            student_score,
        )
        connection.commit()

