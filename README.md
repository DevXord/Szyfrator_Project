# Szyfrowanie/deszyfrowanie plików tekstowych
## z użyciem algorytmów: RSA, AES.


# Właściwości Kontrolek
 

## 1.	Kontrolki przycisku (4 x Button):
### a.	Button „open_bt”  właściwości:
 	Enabled  na wartości „True”
 	Font – Size na wartości 7.2
 	Text z wartością „Open File”

### b.	Button „enc_bt”  właściwości:
 	Enabled  na wartości „False”
 	Font – Size na wartości 7.2
 	Text z wartością „Encrypt”

### c.	Button „save_bt”  właściwości:
 	Enabled  na wartości „False”
 	Font – Size na wartości 7.2
 	Text z wartością „Save File”

### d.	Button „clear_bt”  właściwości:
 	Enabled  na wartości „False”
 	Font – Size na wartości 7.2
 	Text z wartością „Clear”

## 2.	Kontrolki przycisku radiowego (2 x RadioButton 1x CheckBox):

### a.	RadioButton „code1_rb” właściwości:
 	Text z wartością „RSA”

### b.	RadioButton „code1_rb” właściwości:
 	Text z wartością „AES”

## 3.	Kontrolki etykiety (3 x Label):
### a.	Label „label1” właściwości:
 	Font – Size na wartość 13
 	Text na wartość „Open File:”

### b.	Label „label2” właściwości:
 	Font – Size na wartość 13
 	Text na wartość „Results:

### c.	Label „results_lb” właściwości:
 	Font – Size na wartość 13
 	Text na wartość „”

## 4.	Kontrolki pola tekstowego ( 2 x TextBox):
### a.	TextBox „openFile_tb” właściwości:
 	Multiline na wartość „True”
 	Enabled  na wartość „False”
 	BorderStyle na wartość „FixedSingle”
 	Font – Size na wartość 12
 	ReadOnly na wartość „True”

### b.	TextBox „results_tb” właściwości:
 	Multiline na wartość „True”
 	Enabled  na wartość „False”
 	BorderStyle na wartość „FixedSingle”
 	Font – Size na wartość 12
	ReadOnly na wartość „True

# Przydatne metody

## Metoda „createCode” 
### Dodaje losową literę od A do F na końcu każdego bajta zaszyfrowanej wiadomości zapisanej w łańcuchu znaków


## Metoda „uncodeMessage” 
### Kasuje losowe litery wylosowane w metodzie „createCode” i umieszcza otrzymane bajty w tablicy


## Metoda „sendProgramMessage” 
### Ustawia tekst lub czyści etykietę „results_lb” 


## Metoda „getLengthByString” 
### Zwraca wielkość tablicy bajtów zakodowanej wiadomości


## Metoda „configureStream” wraz z nadpisaniem
### Konfiguruje „SaveFileDialog” i „OpenFileDialog”


## Metoda „resetValue”
### Przywraca stan początkowy programu
