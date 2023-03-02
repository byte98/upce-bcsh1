# Správce distribucí datových souborů
Tento projekt obsahuje moji semestrální práci z předmětu KST/BCSH1 - Programování v .NET a C# I.

## Zadání
### Scénář
Mějme autobousovou přepravní společnost. Tato společnost působí ve více různých oblastech a má více různých autobusů. Každý autobus je vybaven palubním informačním systémem pro cestující (dále jen IS). Jelikož však mají palubní jednotky IS omezenou vnitřní paměť, mají k dispozici pouze data pro oblast, na které působí. Aplikace bude umět spravovat distribuci těchto dat. Tyto data jsou uložena pro každou oblast ve vlastním datovém souboru. Protože společnost nakupovala v průběhu let různé autobusy, s různými IS, musí mít navíc každý soubor pro danou oblast i různé varianty pro různé IS. Každý takto specifikovaný soubor bude aplikace kopírovat do předem definovaného adresáře, ze kterých si je stahují palubní jednotky IS.

### Požadavky
#### Entity:
 - Soubor
 - Oblast
 - Informační systém
 - Autobus (resp. postačuje pouze model autobusu)
#### Akce:
 - přidávání všech entit
 - vyhledávání podle oblasti, autobusu či informačního systému
 - mazání všech entit (včetně kaskádové propagace)
 - export dat ze souboru
 - import dat ze souboru
