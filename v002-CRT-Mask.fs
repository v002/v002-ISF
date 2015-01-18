/*{
	"DESCRIPTION": "CRT Mask, emulating the look of curved CRT Displays",
	"CREDIT": "by vade",
	"CATEGORIES": 
	[
		"v002"
	],
	"INPUTS": 
	[
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
	],
	"IMPORTED": 
	{
		"CRTMask": {
			"PATH": "v002-CRT-Mask-RGB-Staggered.png"
		}
	}
}*/

void main (void) 
{ 
	vec2 crtcoord = mod(gl_FragCoord.xy, 12.0);
	vec4 crt = IMG_PIXEL(CRTMask, crtcoord);

	vec4 image = IMG_THIS_PIXEL(inputImage);
	vec4 result = mix(image, image * crt, Amount);
	
	result.a = image.a;
	
	gl_FragColor = result;
}