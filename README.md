# SmartHomeProject

## Rooms and Attributes

- **Kitchen:** Represents stove status as an Enum.
- **Bathroom/Toilet:** Measures humidity as a percentage.
- **Living Room:** Captures ambient lighting color in RGB.
- **Bedroom:** Sets alarm time using DateTime.
- **Sunroom:** Monitors sunlight exposure in Lux.

## Actor Placement

- **Heating Valve:** Available in all rooms except Wintergarten.
- **Blinds Control:** Available in all rooms except Bathroom/Toilet.
- **Awning Control:** Exclusive to winter garden.

## Weather Sensor

- Generates random, realistic weather data:
  - Outside temperature
  - Wind speed
  - Rain (yes/no)

## Behavioral Rules

1. Each room has a predefined temperature. If outside temperature is lower, the heating valve opens for heating.
2. Awning extends when outside temperature exceeds room temperature, provided wind speed is below 30 km/h.
3. Blinds lower automatically if outside temperature exceeds room temperature and no occupants are present.

## Realistic Weather Data

- Smooth temperature progression; no abrupt jumps (e.g., 25°C to 5°C).
- Weather sensor operates on a Tick operation, simulating 1 second intervals.