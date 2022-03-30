L'identificativo di partita IVA, in Italia, si compone di 11 cifre (es.: 1234567 890 1), raggruppate secondo lo schema seguente:

    le prime sette cifre rappresentano il numero di matricola del soggetto assegnato dal relativo ufficio provinciale, che si ottiene incrementando di una unità il numero assegnato al soggetto che lo precede;
    le cifre dalla ottava alla decima indicano il codice dell'ufficio provinciale del fisco che ha rilasciato la matricola, generalmente corrispondente al codice ISTAT della provincia;
    l'undicesima cifra, infine, rappresenta un codice di controllo, introdotto al fine di verificare la correttezza delle prime dieci cifre.

Si noti che il numero della matricola è univoco solo nell'ambito dell'ufficio provinciale che lo ha emesso: pertanto possono essere presenti due uguali numeri di matricola, ma afferenti ad uffici provinciali diversi (e quindi determinanti due diversi numeri di partita IVA).

Sfuggono a questa regola di attribuzione della matricola i soggetti afferenti direttamente alle istituzioni statali, militari, giudiziarie, le persone giuridiche, che hanno il numero di matricola iniziante per 8 o per 9.

L'algoritmo impiegato per calcolare la cifra di controllo è la formula di Luhn:

    Sia X la somma delle prime cinque cifre in posizione dispari
    Sia Y la somma dei doppi delle cinque cifre in posizione pari, sottraendo 9 se il doppio della cifra è superiore a 9
    Sia T=(X+Y) mod 10 l'unità corrispondente alla somma dei numeri sopra calcolati
    Allora la cifra di controllo C = (10-T) mod 10

L'algoritmo impiegato per verificare la cifra di controllo è la formula di Luhn:

    Sia X la somma delle cifre in posizione dispari non considerando l'ultima cifra (che è di controllo)
    Sia Y la somma dei doppi delle cifre in posizione pari
    Sia Z il numero di volte che nei numeri in posizione pari c'è un valore maggiore o uguale a 5
    Sia T=(X+Y+Z) mod 10 l'unità corrispondente alla somma dei numeri sopra calcolati, allora la cifra di controllo C = (10 - T) mod 10

Ad esempio, si vuole calcolare il codice di controllo C della Partita IVA 0764352056C:

0 7 6 4 3 5 2 0 5 6 C (dove C è il codice di controllo da individuare)

    X = 0+6+3+2+5 = 16 (somma delle cifre di posto dispari)
    Y = ((2*7)-9) + 2*4 + ((2*5)-9) + 2*0 + ((2*6)-9) = 17
    T = (16+17) mod 10 = 33 mod 10 = 3 (somma modulo 10)
    C = (10-T) mod 10 = 7 (unità mancanti alla prima decina successiva)

Pertanto il numero di partita IVA sarà 07643520567. Si noti che, qualora si desideri semplicemente verificare la correttezza di un numero di Partita IVA già esistente, è sufficiente calcolare la X includendo anche il codice di controllo: in tal caso l'algoritmo si fermerà al calcolo di T, il cui valore dovrà essere pari a 0 in caso di corretto numero di partita IVA.

Nel caso specifico, si avrà X=23 e quindi T=(23+17) mod 10 = 0 confermando la validità del codice. 
