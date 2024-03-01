
# Blender Geo Nodes

A collection of 9 nodes that you may use in your project to make awesome effects.

# How to use the Geo Nodes

Add the blender file to your asset library and then you'll have access to them.





## Weld
#### Information
---
Drag the weld modifier from your library onto a cube this will be the object that provides the welding. Inside the welding modifier select two different objects.  Anywhere those two objects intersect the weld effect will generate.

> You can choose the weld material in the modifier.

Options | Description
--- | --- 
**Minimum**| `controls the minimum size range of the welding bubbles that appear ` 
**Maximum**| `controls the Maximum size range of the welding bubbles that appear ` 

> Be careful with these if you go too far it can look bad.

## Example

![App Screenshot](https://i.imgur.com/tmr0GMc.png)


## Rope
#### Information
---
Drag the modifier from your library onto a curve.  The rope effect will follow it so you can draw points and move them around for whatever you need.

> You can choose the weld material in the modifier.

Options | Description
--- | --- 
**Rope twists**| `changes the distance between the twists.` 
**thread thickness**| `changes the radius of its thread.` 
**Fray length**| `changes how long the fibers coming off the rope are.` 
**Thread material**| `change the individual threads materials.` 
**Fraying material**| `change the color of the fraying fibers` 

> The default rope material it comes with has ambient occlusion turned on to give the appearance of strings making up each thread.

Remnels Notes:
*  A higher number means further apart twists and lower makes the twists closer.  Anything below 1 starts to look jagged for the rope twists.
* Use the thread thickness if you need a thinner or thicker rope.
* Set the fray length to 0 to have nice smooth rope.
* Thread material is useful if you want ropes made out of metal, webbing or vines.

## Example

![App Screenshot](https://i.imgur.com/k0V1RUJ.png)

## Crystal Cluster
#### Information
---
Drag the modifier from your library onto a mesh.  This becomes your cluster.
I included some example crystal models for this.  If you want to use your own you can delete them. Any mesh you put into the target collection will be randomly clustered together at your object origin. I used crystals but you can use any mesh.

## Example

![App Screenshot](https://i.imgur.com/RCGYdaW.png)


## Crystal Growth
#### Information
---
Drag the modifier from your library onto a mesh.  This will be what the crystals grow from. Select any object you want and it will grow from the mesh.  You can have two different objects that will grow. You can limit the growth areas by using vertex groups.

Options | Description
--- | --- 
**Body material**| `lets you set the material of the object the crystals grow from.` 
**Object Density**| `how many instances of your first object will appear on the target`  
**Object Minimum**| `changes the minimium distance apart any two growths can be.` 
**Object Maximum**| `changes the maximum distance apart any two growths can be.`
**random direction**| `can be turned off to make the growths follow the direction of the face they're growing on.`  

## Example

![App Screenshot](https://i.imgur.com/UjDV31b.png)
## Vine
#### Information
---
Drag the modifier from your library onto a curve or object this will determine what the leaves grow from. The vine will follow any points you draw. The leaves generate from their origin point. I included an example leaf mesh but you can change it to anything you want growing off the vine.

Options | Description
--- | --- 
**Vine thickness**| `It changes the radius of your vine.` 
**Leaf amount**| `how many leaf meshes appear on your vine.` 
**Leaf size**| `changes the size of your leaf mesh growing on the vine.` 

> Leaf and vine material will change the materials assigned to your vines

Remnels Notes:
*  Vine thickness only applies if you use a curve.

## Example

![App Screenshot](https://i.imgur.com/lEULgUz.png)
## Tentacle
#### Information
---
Drag the modifier from your library onto a curve.  This will become the shape your tentacle follows.

> CURRENTLY YOU CANNOT ADD A NEW BEGINNING OR END POINT.  IF YOU WANT MORE POINTS YOU MUST EXTRUDE FROM POINTS IN THE MIDDLE.

Options | Description
--- | --- 
**Tentacle Material**| `sets the material of the tentacle.` 
**Tentacle extend**| `allows you to animate the tentacle distance along the curve.` 
**Tentacle thickness**| `adjusts the radius of the tentacle.` 
**Sucker Radius**| `changes how much of the tentacle has suckers on it.` 
**Sucker Length**| `sets how far in or out the suckers go.` 
**Sucker Density**| `changes how many suckers are packed into the section of tentacle.` 

Remnels Notes:
*  The tentacle will animate wiggle and pulse if you hit play.  To set it up for rigging convert the curve to a mesh.

## Example

![App Screenshot](https://i.imgur.com/25Ri2C3.png)

## Stitching
#### Information
---
Drag the modifer from your library onto an object and then create a curve to assign to the stitch curve box, the stitches will now generate along the curve and pull the mesh tight around them if you have enough geometry.


Options | Description
--- | --- 
**Stitch scale**| `adjusts how big the individual stitches are. If your stitches aren't showing up try turning this up to 20 and adjusting from there` 
**Stitch radius**| `adjusts how thick the individual stitches are.` 
**Stitch offset**| `adjusts how far off the mesh your stitches will be. The spaces between stitches will still go under the surface.` 
**Stitch curve**| `tells the nodes which curve to follow.` 
**Stitch material**| `changes the color and material settings of the curve.`
**Stitch spacing**| `adjusts how far apart the individual stitches are.` 

## Example

![App Screenshot](https://i.imgur.com/DwHHwSw.png)

## Scales
#### Information
---
Drag the modifier from your library onto an object.  This is what the scales will generate on.  They are scaled to match the face they generate on, so more geometry = more scales.

Options | Description
--- | --- 
**Scale size**| `adjusts the scale of the individual scales.` 
**Tilt**| `adjusts the X rotation of the scales.` 
**Swivel**| `adjusts the Y rotation of the scales.` 
**Rotation**| `adjusts the Z rotation of the scales.` 
**Scales model**| `the model that will be generated on the faces.`
**Scales depth**| `adjusts the thickness of the scale mesh.` 
**ScaleVertexGroup**| `allows you to isolate the area of mesh the scales generate on.` 

## Example

![App Screenshot](https://i.imgur.com/JQcMKIt.jpeg)

## Wrap
#### Information 
---
Drag the modifier from your library onto an object.  This will be the wrap.  Set the Object to be wrapped to your target to start.  The origin of the wrap matters for best results center it on your target.  The wrap generates from the origin point and won't pass it.
To add UV maps to the wrap you have to apply the modifier and manually unwrap it from there.

Options | Description 
--- | ---
**Object to be Wrapped**| `Target object the wrap will apply to.`
**Thickness**| `Adjusts how thick the wrap is.`
**Wrap Width**| `Changes how wide the wrap is.`
**Wrap Length**| `Changes how far up or down the object the wrap travels.`
**Rotations**| `How many times the wrap goes around the object before it reaches the set length.`
**Offset**| `How far off the target the wrap sits.`
**Overlap**| `Adjusts the radius of the wrap at the top or bottom edge to add the appearance of overlapping`
**Flip Spiral Direction**| `Changes if the wrap curls clockwise or counter clockwise.  Note that the offset won't work for both directions so you'll have to adjust it as well.`
**Wrap Material**| `The material your wrap will use. It won't have UV's until you apply the modifier so during the setup it will just change the color.`

## Example

![App Screenshot](https://i.imgur.com/TpHorhX.png)

## Barrel
#### Information 
---
Creates a procedurally generated barrel
Options | Description 
--- | ---
**Random Barrel Seed**| `Changes the seed used for the plank heights. Allows for random varients.`
**Plank Count**| `Changes how many planks make up the body of the barrel.  Adjust width accordingly.`
**Barrel Height**| `Changes how tall the barrel is.`
**Plank Width**| `How wide the individual planks are. Basically adjusts the gaps between planks.
**Barrel Bowing**| `How strong the bend in the middle of the barrel is.`
**Metal Ring Size**| `The height and width of the metal rings that hold the planks together`

## Example
!![App Screenshot](https://i.imgur.com/zADVNtM.png)
