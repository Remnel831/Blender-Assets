How to use the Geo Nodes

Add the blender file to your asset library and then you'll have access to them.

WELD

Drag the weld modifier from your library onto a cube this will be the object that provides the welding.

Inside the welding modifier select two different objects.  Anywhere those two objects intersect the weld effect will generate.

You can choose the weld material in the modifier.

Minimum and Maximum size controls the size range of the welding bubbles that appear.  Be careful with these if you go too far it can look bad.




ROPE

Drag the modifier from your library onto a curve.  The rope effect will follow it so you can draw points and move them around for whatever you need.

Rope twists changes the distance between the twists.  A higher number means further apart twists and lower makes the twists closer.  Anything below 1 starts to look jagged.

The different thread thickness sliders just changes the radius of its thread.  You can use this if you need a thinner or thicker rope.

Fray length changes how long the fibers coming off the rope are.  Set it to 0 to have nice smooth rope.

Thread material lets you change the individual threads materials.  Useful if you want ropes made out of metal/webbing/vines ect. 

Fraying material lets you change the color of the fraying fibers.

The default rope material it comes with has ambient occlusion turned on to give the appearance of strings making up each thread.




CRYSTAL CLUSTER

Drag the modifier from your library onto a mesh.  This becomes your cluster.

I included some example crystal models for this.  If you want to use your own you can delete them.

Any mesh you put into the target collection will be randomly clustered together at your object origin. I used crystals but you can use any mesh.




CRYSTAL GROWTH

Drag the modifier from your library onto a mesh.  This will be what the crystals grow from.

Select any object you want and it will grow from the mesh.  You can have two different objects that will grow.   You can limit the growth areas by using vertex groups.

Body material lets you set the material of the object the crystals grow from.

Object Density changes how many instances of your first object will appear on the target.

Object Minimum distance changes the minimium distance apart any two growths can be.

Object Maximum distance changes the maximum distance apart any two growths can be.

The random direction checkbox can be turned off to make the growths follow the direction of the face they're growing on.

VINE

Drag the modifier from your library onto a curve or object this will determine what the leaves grow from. The vine will follow any points you draw.

The leaves generate from their origin point.

I included an example leaf mesh but you can change it to anything you want growing off the vine.

Vine thickness only applies if you use a curve.  It changes the radius of your vine.

Leaf amount changes how many leaf meshes appear on your vine

Leaf size will change the size of your leaf mesh growing on the vine

Leaf and vine material will change the mterials assigned to your vines



TENTACLE

Drag the modifier from your library onto a curve.  This will become the shape your tentacle follows
CURRENTLY YOU CANNOT ADD A NEW BEGINNING OR END POINT.  IF YOU WANT MORE POINTS YOU MUST EXTRUDE FROM POINTS IN THE MIDDLE.

The tentacle will animate wiggle and pulse if you hit play.  To set it up for rigging convert the curve to a mesh. 

The spiral toggle switches the tentacle from following your path to being curled up. 

Tentacle Material sets the material of the tentacle.

Tentacle extend allows you to animate the tentacle distance along the curve.

Tentacle thickness adjusts the radius of the tentacle.

Sucker Radius changes how much of the tentacle has suckers on it

Sucker Length sets how far in or out the suckers go

Sucker Density changes how many suckers are packed into the section of tentacle. 

STITCHING

Drag the modifer from your library onto an object and then create a curve to assign to the stitch curve box

the stitches will now generate along the curve and pull the mesh tight around them if you have enough geometry.

Stitch scale adjusts how big the individual stitches are.

Stitch radius adjusts how thick the individual stitches are.

Stitch offset adjusts how far off the mesh your stitches will be. The spaces between stitches will still go under the surface.

Stitch curve tells the nodes which curve to follow

Stitch material changes the color/material settings of the curve.

Stitch spacing adjusts how far apart the individual stitches are. 

SCALES

Drag the modifier from your library onto an object.  This is what the scales will generate on.  They are scaled to match the face they generate on, so more geometry = more scales.

Scale size adjusts the scale of the individual scales.

Tilt adjusts the X rotation of the scales.

Swivel adjusts the Y rotation of the scales.

Rotation adjusts the Z rotation of the scales.

Scales model is the model that will be generated on the faces.

Scales depth adjusts the thickness of the scale mesh.

ScaleVertexGroup allows you to isolate the area of mesh the scales generate on.

