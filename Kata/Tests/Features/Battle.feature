Feature: Battle

    Scenario: A Pokémon replenishes 20 HP by drinking a potion
        Given Pidgey has 100 HP
        When Pidgey drinks a potion
        Then Pidgey should have 120 HP