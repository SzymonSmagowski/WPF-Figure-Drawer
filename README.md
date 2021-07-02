# WPF-Figure-Drawer
In the project the concept of creating rectangles and elipses has been covered.
After the basis creation in the beginning part there are some detailed properties described here.
# Main Window
1. Icon on the title bar.
2. Maximalized window.
3. Font set to 16.
# Layout
1. App divided into 2 parts: top and bottom.
2. Top part has 6 buttons.
3. On both parts there are canvas.
4. On bottom part there is a gradient.
# Start and general
1. At the start there are 4 random shapes created in the random places.
2. Mouse changes to "Hand" at each shape.
# Selecting shapes
1. Shapes can be selected and desected by right clicking them.
2. There is a stack of selected shapes.
3. Shadow effect was applied to visualise which one is selected.
# Delete and random buttons
1. Random button changes all selected shapes' colors to random ones.
2. Delete button deletes all selected shapes.
# Adding shapes
1. Rectangle and Elipse buttons changes cursor to "Cross".
2. Each figure can be drawn on canvas by left mouse button.
# Changing language
1. There is a button with the flag. 
2. Flag changes according to which country we want to change text. 
3. All strings are stored in the corresponding resx files.
# Exporting image
1. There is a button "Export to .png".
2. It opens dialog window in which we can choose location and a name of future saved file.
3. After pressing "Save" button canvas is being saved with given location and name.
# Shape properties
1. On the left side of the top panel, to the right of existing buttons there are 4 new controls stacked on top of each other. They are used to modify shape width, height, fill color and rotation angle.
2. Width and Height accept only positive, integer nubmers.
3. In color ComboBox there are all colors found in System.WIndows.Media.Colors except for Transparent.
4. Angle Slider gives us a value between -180 and 180 degrees. 
# Color selection
1. Each entry on the list of color has a background in this color.
2. There is a name of the color.
# Selecting shapes
1. When the left mouse button is pressed on an unselected shape, it is selected and all the other shapes are deselected.
2. When pressed anywhere on a canvas outside of any shape all the selected shapes are deselected.
3. Height and Width display correct properties of the last selected shape and update when changing selection.
4. When that shape is deselected, then properties affect the previous shape in the order of shape selection.
5. When no shape is selected, then the shape properties along with the Delete and Random colors buttons are disabled, and the properties are empty.
# Moving shapes
1. When pressing and holding the left mouse button on any selected shape all of them are moving with the mouse cursor.
2. Shapes keep the same relative position to the cursor.
# Rotating shapes
1. Shapes can be rotated by a slider.
