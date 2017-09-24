publish_unity_finger:
	msbuild /p:Configuration=Release UnityFinger/UnityFinger/UnityFinger.csproj
	cp UnityFinger/UnityFinger/obj/Release/UnityFinger.dll Assets/Plugins
