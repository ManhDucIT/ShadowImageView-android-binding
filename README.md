# ShadowImageView-android-binding
This is an Android Binding library for ShadowImageView which provides more exquisite shadow effect, used in some special scene to enhance the user experience and it can also change color according to the picture, more delicate shadow effect.

## Installation 
Install-Package ShadowImageView

![shadow1](https://user-images.githubusercontent.com/24780565/33242423-684d151c-d307-11e7-9d8f-8a4a5beacf8c.png)

![shadow2](https://user-images.githubusercontent.com/24780565/33242424-74f5ccb4-d307-11e7-9a59-b90f20c3590f.gif)

## Usage:

#### Menu behavior
```.xml
<com.yinglan.shadowimageview.ShadowImageView
	            android:id="@+id/shadow"
                android:layout_width="300dp"
                android:layout_height="300dp"
                app:shadowRound="20dp"
                app:shadowSrc="@mipmap/lotus"
                app:shadowColor="@color/colorAccent"/>
```
#### Set picture
```C#
shadow.setImageResource(resID); 
    shadow.setImageDrawable(drawable); 
    shadow.setImageBitmap(bitmap);
```

### Set the picture radius
```
    shadow.setImageRadius(radius);
```
### Set the shadow color of the image
```
    shadow.setImageShadowColor(color);
```

## Special thanks
Thanks to [yingLan](https://github.com/yingLanNull) for a native wonderful initial library [ShadowImageView
](https://github.com/yingLanNull/ShadowImageView).

## License
```
MIT License

Copyright (c) 2017 Dang Manh Duc

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
