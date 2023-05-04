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

    Scenario: A Pokémon loses as many HP as the attack power
        Given the attack 'Steel Wing' has a power of 70
        When Pidgey is attacked with 'Steel Wing'
        Then Pidgey should have 30 HP

    Scenario: A Pokémon cannot have less than 0 HP
        Given the attack Blizzard has a power of 110
        When Pidgey is attacked with Blizzard
        Then Pidgey should have 0 HP