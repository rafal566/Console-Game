using System;

//changing the position of the arrow
// out allows to return more than one value
//static means that behaviour of the method is not specific to any instance
//    but to the class
//
namespace ConsoleGame {
  class Game : SuperGame {
    public new static void UpdatePosition(string key_pressed, out int coordinate_x, out int coordinate_y) {
      switch (key_pressed) {
        case "UpArrow":
          coordinate_x = 0;
          coordinate_y = -1;
          break;
        case "RightArrow":
          coordinate_x = 1;
          coordinate_y = 0;
          break;
        case "DownArrow":
          coordinate_x = 0;
          coordinate_y = 1;
          break;
        case "LeftArrow":
          coordinate_x = -1;
          coordinate_y = 0;
          break;
        default:
        	coordinate_x = 0;
          coordinate_y = 0;
          break;
      }
    }

//changing the appearance of the cursor
  public new static char UpdateCursor(string key_pressed) {
    switch (key_pressed) {
        case "UpArrow":
          return '^';
        case "RightArrow":
          return '>';
        case "DownArrow":
          return 'v';
        case "LeftArrow":
          return '<';
        default:
          return '<';
      }
    }

  //keep cursor in boundry
  public new static int KeepInBounds(int coordinate, int max_value) {
    if(coordinate < 0) {
      return 0;
    } else if (coordinate > max_value) {
      return max_value - 1;
    } else {
      return coordinate;
    }
  }

//update score by comparing coordinates of cursor and @
  public new static bool DidScore(int arr_x, int arr_y, int fruit_x, int fruit_y) {
      if (arr_x == fruit_x && arr_y == fruit_y) {
        return true;
      } else {
        return false;
      }
    }
  }
}
