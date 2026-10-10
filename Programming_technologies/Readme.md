# Student Performance Dashboard

Streamlit və SQL Server istifadə edərək tələbə nəticələrini idarə edən kiçik web tətbiqi.

## Funksiyalar
- Tələbə əlavə etmək (ad və bal)
- Bütün tələbələrin siyahısı (Name, Score, Grade)
- Ada görə axtarış
- Statistika: Total Students, Average, Highest, Lowest 
- `calculate_grade(score)` ilə qiymət hesablanması

## Layihə strukturu
| Fayl | Məsuliyyət |
|------|-----------|
| `app.py` | Streamlit interfeysi |
| `services.py` | Biznes məntiqi (`calculate_grade`, `calculate_statistics`) |
| `database.py` | SQL Server ilə əlaqə (`create_connection`, `add_student`, `get_students`, `get_student`) |
| `config.py` | Sabitlər (database ayarları, grade sərhədləri) |
| `setup.sql` | Database, cədvəl və `GetStudentResult` stored procedure |
| `refactoring_example.py` | Clean Code refactoring nümunəsi |

Qatlar: SQL Server → Database layer → Business logic → Streamlit UI

## İşə salmaq
1. SSMS-də `setup.sql` faylını işlət.
2. `config.py`-də `DB_SERVER` və `DB_DRIVER`-i öz sisteminə görə yoxla.
3. Asılılıqları quraşdır:
   ```
   pip install -r requirements.txt
   ```
4. Tətbiqi başlat:
   ```
   streamlit run app.py
   ```

## Grade cədvəli
| Bal | Grade |
|-----|-------|
| 90+ | A |
| 80-89 | B |
| 70-79 | C |
| 60-69 | D |
| 60-dan aşağı | F |
