import os
from reportlab.lib.pagesizes import A4
from reportlab.lib.units import cm
from reportlab.pdfgen import canvas

def txt_to_pdf(txt_path, title):
    # Basisverzeichnis dynamisch vom Skriptverzeichnis ableiten
    base_dir = os.path.dirname(os.path.abspath(__file__))
    full_txt_path = os.path.join(base_dir, txt_path)

    # Überprüfen, ob die Datei existiert
    if not os.path.isfile(full_txt_path):
        print(f"Fehler: Die Datei '{full_txt_path}' wurde nicht gefunden.")
        return

    # Ausgabe-Verzeichnis erstellen
    output_dir = os.path.join(base_dir, "Lösungen", "PDF")
    os.makedirs(output_dir, exist_ok=True)

    # Pfad zur Ausgabedatei
    pdf_path = os.path.join(output_dir, f"{title}.pdf")

    # PDF erstellen
    c = canvas.Canvas(pdf_path, pagesize=A4)
    width, height = A4

    # Titel hinzufügen
    c.setFont("Helvetica-Bold", 25)
    c.drawCentredString(width / 2.0, height - 2 * cm, title)

    # Inhalt der .txt-Datei lesen und in die PDF schreiben
    c.setFont("Helvetica", 16)
    text_obj = c.beginText(2 * cm, height - 4 * cm)
    text_obj.setLeading(20)  # Zeilenabstand

    # .txt-Datei lesen und Zeilen hinzufügen
    with open(full_txt_path, 'r', encoding='utf-8') as txt_file:
        for line in txt_file:
            text_obj.textLine(line.strip('\n'))

    # Inhalt zur PDF-Seite hinzufügen und speichern
    c.drawText(text_obj)
    c.save()

    print(f"PDF wurde gespeichert unter: {pdf_path}")

# Beispielaufruf, Verzeichnis wird relativ zum Skriptpfad ermittelt
txt_to_pdf("Lösungen/UserCase/2.2ÜbungUseCase.txt", "Use Case Übung 2.2")