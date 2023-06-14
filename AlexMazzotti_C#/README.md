# OOP_draft_csharp
Alex Mazzotti
Versione in C# per progetto d'esame di OOP.
L'applicazione è la versione in c# di una parte del progetto in java, in particolare si rielaborano la scelta del modulo, e la creazione della squadra attraverso Draft.

Il funzionamento, in breve: 
1) si legge, inizialmente, un file contentente una lista di calciatori in cui in ogni riga ci sono un calciatore e il suo ruolo corrispondente separati da un ';'.
2) in una dialog l'user deve scegliere un modulo.
3) in base al modulo, la gui genera 11 button, (es se scelto come modulo 4-4-2, la gui avrà 1 button per il Portiere, 4 per i difensori, 4 per i centrocampisti, 2 per gli attaccanti).
4) al click del button il sistema propone 5 calciatori casuali del ruolo corrispondente.
5) una volta scelti gli 11 calciatori il sistema si può chiudere con un button close.

Si è cercato di seguire il pattern MVC.
