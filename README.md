SlnGenerateCode
=======================================================================================

基于spring.net与DevExpress的代码生成器

### 版本

    - V3.0
    
### 发起原因

    - 针对当前操作数据库的各种应用软件时，软件工程师要写一大堆的存储数据库的sql语句,
          在系统变更需求时，会出现维护工作量繁重等现象。
          
### 目的

    - 让程序员轻松写代码，免除繁重的重复工作，把更多时间放在业务逻辑的设计层面。
    
### 语言

    - c#
    
### 框架

    - devexpress 10.2、spring.net
    
### 入口项目名

    - iCatGenerater

### 主要功能有如下：

    - 可设定存放近期使用的数据库连接。
    - 界面任何状态下不会产生假死（线程阻塞）现象。
    - 生成的代码层有Dao、IDao、Model、Service、IService的全部代码和Client（应用层）部分代码。
