# AR-vuforia-test
这是一个使用vuforia进行创作的AR作品，融合了图片识别的库，主要功能是识别图片出现模型和识别图片出现视频这两种。但是给模型添加了手势控制（旋转缩放），给视频添加了暂停播放，最终呈现出生日贺卡的模样。

环境：windows10+vuforia

配置注意：在vuforia官网注册账号并上传对应的图片，复制对应的注册码
![Uploading ef6e7288b1aed601bd2aa6515a09938.png…]()

# 导出adk备注：

注意检查是否为IL2cpp

注意检查公司名不能为默认名称

注意检查Android最低版本必须在8.0以上

当使用foundation的时候二者会冲突，foundation的报错会影响vuforia

编辑器安装都不能有中文路径！！！

# 参考：

https://www.youtube.com/watch?v=-bF0oxgtt6A

最终视频demo链接：

【[unity+vuforia]AR结课作业-洛天依的生日贺卡】 https://www.bilibili.com/video/BV1Dw411j71k/?share_source=copy_web&vd_source=234af0a1832951571b35315678c597b9

# 难点备注

当时做的时候遇见的最大的困难是调整双指缩放和单指旋转，参考了csdn博客，但是运行起来还是会卡bug，最后借助gpt修正。

目前的bug：

图片走出画面之后识别出的模型并不会消失，但是在最开始的场景中测试却没有这个问题，在代码中手动调整，比如添加if-else条件，得到了部分改善，但是这个问题并没有完全根除。

# apk链接：

链接：https://pan.baidu.com/s/1xd8MAE8B_85oMsvK9HhmXg?pwd=oiss 
提取码：oiss
