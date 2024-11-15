from reportlab.lib import colors
from reportlab.lib.pagesizes import letter
from reportlab.lib.styles import getSampleStyleSheet, ParagraphStyle
from reportlab.platypus import SimpleDocTemplate, Paragraph, Table, TableStyle, Spacer
import os

def txt_to_pdf(filePath, überschrift, targetPath):
    # Dokument erstellen
    document = SimpleDocTemplate(
        targetPath,
        pagesize=letter,
        leftMargin=20,
        rightMargin=20,
        topMargin=20,
        bottomMargin=20
    )
    
    # Stile definieren
    styles = getSampleStyleSheet()

    # Erstellen eines benutzerdefinierten ParagraphStyle für die Überschrift
    überschrift_style = ParagraphStyle(
        name="ÜberschriftStyle",
        parent=styles['Heading1'],
        fontSize=18,  # Schriftgröße auf 18 setzen
        alignment=1,  # Zentrieren
        spaceAfter=12,  # Abstand nach der Überschrift
    )
    
    # Benutzerdefinierten Stil für den Fließtext erstellen
    text_style = ParagraphStyle(
        name="TextStyle",
        fontSize=12,  # Standard-Schriftgröße für den Text
        alignment=0,  # Links ausrichten
        spaceAfter=8,  # Abstand nach jedem Absatz
    )

    elements = []

    # Überschrift hinzufügen
    überschrift_data = [
        [Paragraph(f"<b>{überschrift}</b>", überschrift_style)]
    ]
    überschrift_table = Table(überschrift_data, colWidths=250)
    überschrift_table.setStyle(TableStyle([
        ('VALIGN', (0, 0), (-1, -1), 'TOP'),
        ('ALIGN', (0, 0), (-1, -1), 'CENTER'),
        ('GRID', (0, 0), (-1, -1), 0, colors.black)
    ]))
    elements.append(überschrift_table)
    elements.append(Spacer(1, 40))

    # Text aus der .txt-Datei einlesen
    if os.path.exists(filePath):
        with open(filePath, 'r', encoding='utf-8') as file:
            text_content = file.read()

        # Den Text in Absätze aufteilen und einfügen
        for paragraph in text_content.split('\n'):
            p = Paragraph(paragraph, text_style)
            elements.append(p)
    else:
        print(f"Die Datei {filePath} existiert nicht.")

    # PDF erstellen
    document.build(elements)

    print(f"PDF wurde erstellt.\nPfad: {filePath}\nName: {überschrift}")

# Beispielaufruf
if __name__ == "__main__":
    # Nicht Verändern
    useCase = "Lösungen/UseCase/"
    userStory = "Lösungen/UserStory/"
    txt = ".txt"
    pdf = ".pdf"

    # Hier anpassen
    fileName = "ÜbungUserStory2_2"
    überschrift = "UserStory Übung 2.2"

    # Passe hier nur userStory/useCase an
    useFile = f"{userStory}{fileName}{txt}"
    targetPath = f"Lösungen/PDF/{fileName}{pdf}"

    if os.path.exists(useFile):
        print("Starte mit dem Erstellen der PDF.")
        txt_to_pdf(useFile, überschrift, targetPath)
    else:
        print("Text-Datei nicht gefunden.")