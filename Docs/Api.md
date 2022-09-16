# Meal Customizer API

- [Meal Customizer API](#meal-customizer-api)
  - [Create meal](#create-meal)
    - [Create meal Request](#create-meal-request)
    - [Create meal Response](#create-meal-response)
  - [Get meal](#get-meal)
    - [Get meal Request](#get-meal-request)
    - [Get meal Response](#get-meal-response)
  - [Update meal](#update-meal)
    - [Update meal Request](#update-meal-request)
    - [Update meal Response](#update-meal-response)
  - [Delete meal](#delete-meal)
    - [Delete meal Request](#delete-meal-request)
    - [Delete meal Response](#delete-meal-response)

## Create meal

### Create meal Request

```js
POST / meals;
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy meal..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": ["Oatmeal", "Avocado Toast", "Omelette", "Salad"],
    "Sweet": ["Cookie"]
}
```

### Create meal Response

```js
Status code = 201 [Created]
```

```yml
Location: {{host}}/meals/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy meal..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": ["Oatmeal", "Avocado Toast", "Omelette", "Salad"],
    "Sweet": ["Cookie"]
}
```

## Get meal

### Get meal Request

```js
GET /meals/{{id}}
```

### Get meal Response

```js
Status code = 200 [Ok]
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy meal..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": ["Oatmeal", "Avocado Toast", "Omelette", "Salad"],
    "Sweet": ["Cookie"]
}
```

## Update meal

### Update meal Request

```js
PUT /meals/{{id}}
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy meal..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": ["Oatmeal", "Avocado Toast", "Omelette", "Salad"],
    "Sweet": ["Cookie"]
}
```

### Update meal Response

```js
Status Code = 204 [No Content] 
```

or

```js
Status code = 201 [Created]
```

```yml
Location: {{host}}/meals/{{id}}
```

## Delete meal

### Delete meal Request

```js
DELETE /meals/{{id}}
```

### Delete meal Response

```js
Status Code = 204 [No Content]
```
