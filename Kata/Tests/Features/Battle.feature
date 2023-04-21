Feature: Battle

    Background:
        Given Pidgey has 100 HP

    Scenario: A Pokémon replenishes 20 HP by drinking a potion
        When Pidgey drinks a potion
        Then Pidgey should have 120 HP

    Scenario: A Pokémon cannot exceed its maximum HP by drinking a potion
        Given Pidgey has 110 maximum HP
        When Pidgey drinks a potion
        Then Pidgey should have 110 HP