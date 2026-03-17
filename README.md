1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?
fast forward wykona przy mergu gdy main nie bedzie mial nowych commitow po stworzenia brancha.
merge commit pojawi sie gdy przy mergu dwoch galezi jest miejsce gdzie byl na inny sposob zmieniony jak w jednej tak i w drugiej galezi
2. Czym w praktyce różni się merge od rebase?
merge laczy dwie galezie i zachowuje rozgaleziona historie.
rebase przenosi commity jednej galezi na koniec drugiej.
3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?
osobiscie pomogl mi funkcja edytora ktora otworzyla sporne miejsce i poprosila wybrac co usunac i co zostawic :))
faktycznie normalnie to ma byc podobnie ale dluzej i mniej przyjemnie

Zadanie 5 - Merge bez fast-forward
nie byla fast forward bo merge byl nie do wyjsciowego maina a do zmodyfikowanego maina.
gdyby nie bylo zmian w maine to program po prostu dodalby bez zadnych zmian nowa galez do maina.
tym razem niestety tak nie bylo wiec mial git rozwiazac konflikty ktore mogly sie pojawic po zmianie maina