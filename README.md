# Auios.Rectangle

## Fields:
| Type | Name | Description |
|-|-|-|
| float | X | Left most value
| float | Y | Top most value
| float | Width | Width of the rectangle
| float | Height | Height of the rectangle

## Properties:
| Type | Name | Description |
|-|-|-|
| float | Top |
| float | Bottom |
| float | Left |
| float | Right |
| float | HalfWidth |
| float | HalfHeight |
| float | CenterX |
| float | CenterY |
| Vector2 | Position |
| Vector2 | Size |
| Vector2 | Half |
| Vector2 | Center |

## Methods
| Type | Name | Description |
|-|-|-|
| bool | Rectangle(X, Y, Width, Height) | Constructor
| bool | Overlaps(X, Y) | Return true if X, Y is within the rectangle
| bool | Overlaps(Rectangle) | Return true if another rectangle intersects this rectangle
| bool | Overlaps(Circle) | (not implemented)
