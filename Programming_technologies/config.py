"""Layihənin sabitləri və konfiqurasiyası."""

import streamlit as st

# --- Score limitləri ---
MIN_SCORE = 0
MAX_SCORE = 100

# --- Grade sərhədləri (böyükdən kiçiyə) ---
GRADE_THRESHOLDS = [
    (90, "A"),
    (80, "B"),
    (70, "C"),
    (60, "D"),
]
FAILING_GRADE = "F"


def load_database_settings():
    """Database məlumatlarını Streamlit Secrets-dən oxuyur (kodda şifrə saxlanmır)."""
    return {
        "server": st.secrets["database"]["server"],
        "user": st.secrets["database"]["user"],
        "password": st.secrets["database"]["password"],
        "database": st.secrets["database"]["name"],
    }
