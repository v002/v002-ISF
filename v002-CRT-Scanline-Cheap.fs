/*{
	"DESCRIPTION": "CRT Scan Line Emulation - Dirty and Fast",
	"CREDIT": "by vade",
	"CATEGORIES": [
		"v002"
	],
	"INPUTS": [
		{
			"NAME": "inputImage",
			"TYPE": "image"
		},
		{
			"NAME": "Amount",
			"TYPE": "float",
			"DEFAULT": 0.5,
			"MIN": 0.0,
			"MAX": 1.0
		}
	]
}*/

void main (void) 
{ 
	vec4 scanlines;
	scanlines = vec4(floor(mod(gl_FragCoord.y + 1.0, 4.0)));
	scanlines = clamp(scanlines, 0.0, 1.0);
	
	vec4 result = IMG_THIS_PIXEL(inputImage);
	gl_FragColor = mix(result, result * scanlines, Amount);
}