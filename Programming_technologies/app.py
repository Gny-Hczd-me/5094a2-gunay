"""Streamlit UI."""

import streamlit as st

from config import MAX_SCORE, MIN_SCORE
from database import add_student, get_student, get_students
from services import build_student_table, calculate_statistics


def render_add_student_form():
    st.subheader("Add Student")
    student_name = st.text_input("Student Name")
    student_score = st.number_input(
        "Score", min_value=MIN_SCORE, max_value=MAX_SCORE, step=1
    )

    if st.button("Add Student"):
        if not student_name.strip():
            st.error("Student name cannot be empty.")
            return
        add_student(student_name.strip(), int(student_score))
        st.success(f"{student_name} added.")


def render_statistics(students):
    scores = [score for _, score in students]
    stats = calculate_statistics(scores)
