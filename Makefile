build:
	msbuild /p:Configuration=Release UnityFinger/UnityFinger/UnityFinger.csproj

publish_mac: build
	cp UnityFinger/UnityFinger/obj/Release/UnityFinger.dll Assets/Plugins

publish_win: build
	copy .\UnityFinger\UnityFinger\obj\Release\UnityFinger.dll .\Assets\Plugins