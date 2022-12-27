vector colorRand = rand(@ptnum);
float coloringFrame = rand(@ptnum*12);
coloringFrame = fit(coloringFrame, 0, 1, 2, 140);
coloringFrame = rint(coloringFrame);

if(@Frame < coloringFrame && @P.y<0) {
    //v@Cd = colorRand;
}
else {
    removepoint(0, @ptnum);
}
