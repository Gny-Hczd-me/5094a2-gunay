import requests

def havani_goster_acarsiz(seher_adi):
    # Bu server heç bir API açarı tələb etmir
    url = f"https://wttr.in/{seher_adi}?format=j1"
    
    try:
        cavab = requests.get(url)
        
        if cavab.status_code == 200:
            melumat = cavab.json()
            cari_hava = melumat["current_condition"][0]
            
            temperatur = cari_hava["temp_C"]
            hiss_olunan = cari_hava["FeelsLikeC"]
            hava_durumu = cari_hava["weatherDesc"][0]["value"]
            kulek = cari_hava["windspeedKmph"]
            
            print(f"\n--- {seher_adi.capitalize()} üçün hava məlumatı ---")
            print(f"Temperatur: {temperatur}°C (Hiss olunan: {hiss_olunan}°C)")
            print(f"Vəziyyət: {hava_durumu}")
            print(f"Küləyin sürəti: {kulek} km/s\n")
        else:
            print(f"\nXəta: '{seher_adi}' adlı şəhər tapılmadı. Adı ingilis hərfləri ilə yazmağa çalışın.\n")
            
    except requests.exceptions.RequestException as e:
        print("İnternet bağlantısında və ya serverdə xəta baş verdi:", e)

# Proqramı işə salan əsas hissə
print("Hava Proqramına Xoş Gəldiniz (Açarsız Versiya)!")
isteyilen_seher = input("Şəhərin adını yazın (məsələn, Baku, Ganja, London): ")

havani_goster_acarsiz(isteyilen_seher)