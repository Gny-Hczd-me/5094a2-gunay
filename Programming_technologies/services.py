"""Business logic: database və UI-dan asılı deyil."""

from config import FAILING_GRADE, GRADE_THRESHOLDS


def calculate_grade(student_score):
    for minimum_score, grade in GRADE_THRESHOLDS:
        if student_score >= minimum_score:
            return grade
    return FAILING_GRADE


def calculate_statistics(scores):
    if not scores:
        return {"total": 0, "average": 0, "highest": 0, "lowest": 0}

    return {
        "total": len(scores),
        "average": round(sum(scores) / len(scores), 1),
        "highest": max(scores),
        "lowest": min(scores),
    }


def build_student_table(students):
    return [
        {"Name": name, "Score": score, "Grade": calculate_grade(score)}
        for name, score in students
    ]
