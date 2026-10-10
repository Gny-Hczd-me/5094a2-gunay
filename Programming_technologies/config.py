"""Layihənin sabitləri və konfiqurasiyası."""

# --- Database ---
DB_DRIVER = "ODBC Driver 17 for SQL Server"
DB_SERVER = "localhost"
DB_NAME = "UniversityDB"

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
