def f(x):
    if x >= 90:
        return "A"
    elif x >= 80:
        return "B"
    elif x >= 70:
        return "C"
    elif x >= 60:
        return "D"
    else:
        return "F"

def p(l):
    t = 0
    for i in l:
        t = t + i
    print("avg", t / len(l))
    print("max", max(l))

# ---------- YAXŞI ----------
EXCELLENT_SCORE = 90
GOOD_SCORE = 80
AVERAGE_SCORE = 70
PASSING_SCORE = 60


def calculate_grade(student_score):
    if student_score >= EXCELLENT_SCORE:
        return "A"
    if student_score >= GOOD_SCORE:
        return "B"
    if student_score >= AVERAGE_SCORE:
        return "C"
    if student_score >= PASSING_SCORE:
        return "D"
    return "F"


def calculate_average(scores):
    return sum(scores) / len(scores)


def print_statistics(scores):
    print("Average:", calculate_average(scores))
    print("Highest:", max(scores))
