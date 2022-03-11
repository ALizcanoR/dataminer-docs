---
uid: GetElementIndexPageForView
---

# GetElementIndexPageForView

Use this method to retrieve the first letters of all the elements in a view.

## Input

| Item            | Format  | Description                                          |
|-----------------|---------|------------------------------------------------------|
| Connection      | String  | The connection ID. See [ConnectApp](xref:ConnectApp). |
| ViewID          | Integer | The view ID.                                         |
| IncludeSubViews | Boolean | Whether subviews should be included.              |

## Output

| Item                              | Format          | Description                                                  |
|-----------------------------------|-----------------|--------------------------------------------------------------|
| GetElementIndexPage­ForViewResult  | Array of string | The first letters of all the elements in the specified view. |
