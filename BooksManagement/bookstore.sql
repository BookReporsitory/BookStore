/*
Navicat MySQL Data Transfer

Source Server         : lochost
Source Server Version : 50096
Source Host           : localhost:3306
Source Database       : bookstore

Target Server Type    : MYSQL
Target Server Version : 50096
File Encoding         : 65001

Date: 2013-11-01 17:03:39
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `book`
-- ----------------------------
DROP TABLE IF EXISTS `book`;
CREATE TABLE `book` (
  `ID` varchar(50) NOT NULL,
  `categoryid` varchar(50) default NULL,
  `bookname` varchar(500) NOT NULL,
  `location` varchar(2000) NOT NULL,
  `picture` varchar(2000) default NULL,
  `uri` varchar(2000) default NULL,
  `readtimes` int(50) default '0',
  PRIMARY KEY  (`ID`),
  KEY `idx_id` (`ID`),
  KEY `fk_categoryid` (`categoryid`),
  CONSTRAINT `fk_categoryid` FOREIGN KEY (`categoryid`) REFERENCES `category` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of book
-- ----------------------------
INSERT INTO `book` VALUES ('001528e6-f0d5-4482-88ac-ffe8e67e20f6', 'be13cd45-fd37-4a96-b855-d99f3416c732', 'The National System ofPolitical Economy《政治经济学的国民体系》.pdf', 'D:\\BookRepository\\BookStore\\经管\\The National System ofPolitical Economy《政治经济学的国民体系》.pdf', null, 'http://book.douban.com/subject_search?search_text=The National System ofPolitical Economy《政治经济学的国民体系》.pdf', '0');
INSERT INTO `book` VALUES ('00276daa-22d1-4831-89dc-bd8a341e5775', '6524c87a-ef83-4adc-b652-32348692d696', '白垩纪往事.epub', 'D:\\BookRepository\\BookStore\\文学\\小说\\白垩纪往事.epub', 'D:\\BookRepository\\Pictures\\00276daa-22d1-4831-89dc-bd8a341e5775白垩纪往事.epub.jpg', 'http://book.douban.com/subject_search?search_text=白垩纪往事.epub', '1');
INSERT INTO `book` VALUES ('010e368d-4dfb-4369-80b6-50b821bbf6b9', '2aaa037e-72f9-4be5-90fe-7346f554c380', '历史的观念.pdf', 'D:\\BookRepository\\BookStore\\历史\\历史的观念.pdf', 'D:\\BookRepository\\Pictures\\010e368d-4dfb-4369-80b6-50b821bbf6b9历史的观念.pdf.jpg', 'http://book.douban.com/subject_search?search_text=历史的观念.pdf', '0');
INSERT INTO `book` VALUES ('021eb8ef-279a-4bc5-a83d-0027738c0974', 'a16749a3-fc05-48ee-96d4-52c1fc0243ac', '《怪诞行为学2：非理性的积极力量》.pdf', 'D:\\BookRepository\\BookStore\\心理学\\《怪诞行为学2：非理性的积极力量》.pdf', 'D:\\BookRepository\\Pictures\\021eb8ef-279a-4bc5-a83d-0027738c0974《怪诞行为学2：非理性的积极力量》.pdf.jpg', 'http://book.douban.com/subject_search?search_text=《怪诞行为学2：非理性的积极力量》.pdf', '0');
INSERT INTO `book` VALUES ('040e602e-89c5-4af0-83af-098fe687fd17', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '哈维尔文集.pdf', 'D:\\BookRepository\\BookStore\\社科\\哈维尔文集.pdf', 'D:\\BookRepository\\Pictures\\040e602e-89c5-4af0-83af-098fe687fd17哈维尔文集.pdf.jpg', 'http://book.douban.com/subject_search?search_text=哈维尔文集.pdf', '0');
INSERT INTO `book` VALUES ('06615fce-348f-448b-ab38-31ff96982347', '6524c87a-ef83-4adc-b652-32348692d696', '《三体》三部完整精校版.pdf', 'D:\\BookRepository\\BookStore\\文学\\小说\\《三体》三部完整精校版.pdf', null, 'http://book.douban.com/subject_search?search_text=《三体》三部完整精校版.pdf', '0');
INSERT INTO `book` VALUES ('08813fb6-29ed-4a84-abb4-17fa9a23e3d2', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '通往奴役之路.mobi', 'D:\\BookRepository\\BookStore\\社科\\通往奴役之路.mobi', 'D:\\BookRepository\\Pictures\\08813fb6-29ed-4a84-abb4-17fa9a23e3d2通往奴役之路.mobi.jpg', 'http://book.douban.com/subject_search?search_text=通往奴役之路.mobi', '0');
INSERT INTO `book` VALUES ('0900337e-2f52-4e63-b1c5-6c1c83d986dd', '1117d65e-a351-46ea-8197-a2d2e6df4161', '麦肯锡方法.pdf', 'D:\\BookRepository\\BookStore\\方法论\\麦肯锡方法.pdf', 'D:\\BookRepository\\Pictures\\0900337e-2f52-4e63-b1c5-6c1c83d986dd麦肯锡方法.pdf.jpg', 'http://book.douban.com/subject_search?search_text=麦肯锡方法.pdf', '0');
INSERT INTO `book` VALUES ('0c2ce189-5fb2-4f1c-85ae-c9748a1f4e6a', 'a16749a3-fc05-48ee-96d4-52c1fc0243ac', '男人来自火星，女人来自金星.pdf', 'D:\\BookRepository\\BookStore\\心理学\\男人来自火星，女人来自金星.pdf', 'D:\\BookRepository\\Pictures\\0c2ce189-5fb2-4f1c-85ae-c9748a1f4e6a男人来自火星，女人来自金星.pdf.jpg', 'http://book.douban.com/subject_search?search_text=男人来自火星，女人来自金星.pdf', '0');
INSERT INTO `book` VALUES ('0c3c83b4-7460-4509-8b31-167c21114ce1', '6524c87a-ef83-4adc-b652-32348692d696', '动物农庄.epub', 'D:\\BookRepository\\BookStore\\文学\\小说\\动物农庄.epub', 'D:\\BookRepository\\Pictures\\0c3c83b4-7460-4509-8b31-167c21114ce1动物农庄.epub.jpg', 'http://book.douban.com/subject_search?search_text=动物农庄.epub', '0');
INSERT INTO `book` VALUES ('0e031cb9-81a7-4724-8c33-55ec54acc15e', 'be13cd45-fd37-4a96-b855-d99f3416c732', '优势谈判.epub', 'D:\\BookRepository\\BookStore\\经管\\优势谈判.epub', 'D:\\BookRepository\\Pictures\\0e031cb9-81a7-4724-8c33-55ec54acc15e优势谈判.epub.jpg', 'http://book.douban.com/subject_search?search_text=优势谈判.epub', '1');
INSERT INTO `book` VALUES ('0eef0883-456a-4431-bbf6-1b0584998685', '9f4411f1-ba98-4197-a444-dcd97f129028', '一只特立独行的猪.epub', 'D:\\BookRepository\\BookStore\\文学\\杂文\\一只特立独行的猪.epub', 'D:\\BookRepository\\Pictures\\0eef0883-456a-4431-bbf6-1b0584998685一只特立独行的猪.epub.jpg', 'http://book.douban.com/subject_search?search_text=一只特立独行的猪.epub', '0');
INSERT INTO `book` VALUES ('11f91b90-0a5b-49cf-9f25-512c2c888e0e', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '追寻现代中国.epub', 'D:\\BookRepository\\BookStore\\社科\\追寻现代中国.epub', 'D:\\BookRepository\\Pictures\\11f91b90-0a5b-49cf-9f25-512c2c888e0e追寻现代中国.epub.jpg', 'http://book.douban.com/subject_search?search_text=追寻现代中国.epub', '0');
INSERT INTO `book` VALUES ('127f5731-6a3a-4c8e-ab5a-a1b623eb1911', '2aaa037e-72f9-4be5-90fe-7346f554c380', '剑桥中华民国史上.pdf', 'D:\\BookRepository\\BookStore\\历史\\剑桥中华民国史上.pdf', 'D:\\BookRepository\\Pictures\\127f5731-6a3a-4c8e-ab5a-a1b623eb1911剑桥中华民国史上.pdf.jpg', 'http://book.douban.com/subject_search?search_text=剑桥中华民国史上.pdf', '0');
INSERT INTO `book` VALUES ('12aab283-4ca8-46e8-89f3-047e4fbdeba9', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '论自由.mobi', 'D:\\BookRepository\\BookStore\\社科\\论自由.mobi', 'D:\\BookRepository\\Pictures\\12aab283-4ca8-46e8-89f3-047e4fbdeba9论自由.mobi.jpg', 'http://book.douban.com/subject_search?search_text=论自由.mobi', '0');
INSERT INTO `book` VALUES ('140f4ac5-bcca-4ec6-8912-d36ad06849ca', '6524c87a-ef83-4adc-b652-32348692d696', '欧亨利短篇小说集.epub', 'D:\\BookRepository\\BookStore\\文学\\小说\\欧亨利短篇小说集.epub', 'D:\\BookRepository\\Pictures\\140f4ac5-bcca-4ec6-8912-d36ad06849ca欧亨利短篇小说集.epub.jpg', 'http://book.douban.com/subject_search?search_text=欧亨利短篇小说集.epub', '0');
INSERT INTO `book` VALUES ('14ab3078-f5fd-4a73-9c45-c60dff367139', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '国家的穷与富.pdf', 'D:\\BookRepository\\BookStore\\社科\\国家的穷与富.pdf', 'D:\\BookRepository\\Pictures\\14ab3078-f5fd-4a73-9c45-c60dff367139国家的穷与富.pdf.jpg', 'http://book.douban.com/subject_search?search_text=国家的穷与富.pdf', '1');
INSERT INTO `book` VALUES ('15f1aa4f-5587-45da-a3e6-f16724603649', '1117d65e-a351-46ea-8197-a2d2e6df4161', '黑天鹅.epub', 'D:\\BookRepository\\BookStore\\方法论\\黑天鹅.epub', 'D:\\BookRepository\\Pictures\\15f1aa4f-5587-45da-a3e6-f16724603649黑天鹅.epub.jpg', 'http://book.douban.com/subject_search?search_text=黑天鹅.epub', '0');
INSERT INTO `book` VALUES ('1618c092-1d61-4c31-b718-5a4fc25dbe40', 'dfa03605-ce58-435f-956f-9150f8303d90', '[德]黑格尔 - 小逻辑.epub', 'D:\\BookRepository\\BookStore\\哲学\\[德]黑格尔 - 小逻辑.epub', null, 'http://book.douban.com/subject_search?search_text=[德]黑格尔 - 小逻辑.epub', '0');
INSERT INTO `book` VALUES ('163f74e4-ac31-4e55-8afa-a9a9d1bf6dd5', '1117d65e-a351-46ea-8197-a2d2e6df4161', '卓越领导者的智慧.epub', 'D:\\BookRepository\\BookStore\\方法论\\卓越领导者的智慧.epub', 'D:\\BookRepository\\Pictures\\163f74e4-ac31-4e55-8afa-a9a9d1bf6dd5卓越领导者的智慧.epub.jpg', 'http://book.douban.com/subject_search?search_text=卓越领导者的智慧.epub', '0');
INSERT INTO `book` VALUES ('16baa7d4-a431-4455-b6f8-1064c9fe3aa3', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '论美国的民主.epub', 'D:\\BookRepository\\BookStore\\社科\\论美国的民主.epub', 'D:\\BookRepository\\Pictures\\16baa7d4-a431-4455-b6f8-1064c9fe3aa3论美国的民主.epub.jpg', 'http://book.douban.com/subject_search?search_text=论美国的民主.epub', '0');
INSERT INTO `book` VALUES ('16dd6979-f156-4178-9b67-f55ee4b820d8', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '中国防火长城——互联网审查的法律经济学.PDF', 'D:\\BookRepository\\BookStore\\社科\\中国防火长城——互联网审查的法律经济学.PDF', 'D:\\BookRepository\\Pictures\\16dd6979-f156-4178-9b67-f55ee4b820d8中国防火长城——互联网审查的法律经济学.PDF.jpg', 'http://book.douban.com/subject_search?search_text=中国防火长城——互联网审查的法律经济学.PDF', '0');
INSERT INTO `book` VALUES ('1e7b321b-8008-40d4-84f3-62f4d39a8b52', '6524c87a-ef83-4adc-b652-32348692d696', '包法利夫人.pdf', 'D:\\BookRepository\\BookStore\\文学\\小说\\包法利夫人.pdf', 'D:\\BookRepository\\Pictures\\1e7b321b-8008-40d4-84f3-62f4d39a8b52包法利夫人.pdf.jpg', 'http://book.douban.com/subject_search?search_text=包法利夫人.pdf', '0');
INSERT INTO `book` VALUES ('1ef37675-29fe-4bf1-97d5-490bb946d651', 'ef672de5-ac8f-4106-a3ac-28a4c6799687', '上帝掷骰子吗-量子物理史话.mobi', 'D:\\BookRepository\\BookStore\\自然科学\\上帝掷骰子吗-量子物理史话.mobi', 'D:\\BookRepository\\Pictures\\1ef37675-29fe-4bf1-97d5-490bb946d651上帝掷骰子吗-量子物理史话.mobi.jpg', 'http://book.douban.com/subject_search?search_text=上帝掷骰子吗-量子物理史话.mobi', '0');
INSERT INTO `book` VALUES ('1efd9ed1-718c-46e7-8c66-658bf64534ea', 'a16749a3-fc05-48ee-96d4-52c1fc0243ac', '动机与人格.epub', 'D:\\BookRepository\\BookStore\\心理学\\动机与人格.epub', 'D:\\BookRepository\\Pictures\\1efd9ed1-718c-46e7-8c66-658bf64534ea动机与人格.epub.jpg', 'http://book.douban.com/subject_search?search_text=动机与人格.epub', '0');
INSERT INTO `book` VALUES ('21832a84-895b-4109-b38f-bc2640dac202', 'a16749a3-fc05-48ee-96d4-52c1fc0243ac', '心理学与生活.epub', 'D:\\BookRepository\\BookStore\\心理学\\心理学与生活.epub', 'D:\\BookRepository\\Pictures\\21832a84-895b-4109-b38f-bc2640dac202心理学与生活.epub.jpg', 'http://book.douban.com/subject_search?search_text=心理学与生活.epub', '1');
INSERT INTO `book` VALUES ('21a86122-0fa8-4879-b21a-4beaf235c6a8', 'be13cd45-fd37-4a96-b855-d99f3416c732', 'The Principles ofEconomics《经济学原理》.pdf', 'D:\\BookRepository\\BookStore\\经管\\The Principles ofEconomics《经济学原理》.pdf', 'D:\\BookRepository\\Pictures\\21a86122-0fa8-4879-b21a-4beaf235c6a8The Principles ofEconomics《经济学原理》.pdf.jpg', 'http://book.douban.com/subject_search?search_text=The Principles ofEconomics《经济学原理》.pdf', '0');
INSERT INTO `book` VALUES ('265145c7-822d-4c93-bd1c-48d2b9fae39d', '03f7f27d-1960-4e08-a9cd-32aba38f8823', 'facebook_Effect.epub', 'D:\\BookRepository\\BookStore\\IT\\facebook_Effect.epub', 'D:\\BookRepository\\Pictures\\265145c7-822d-4c93-bd1c-48d2b9fae39dfacebook_Effect.epub.jpg', 'http://book.douban.com/subject_search?search_text=facebook_Effect.epub', '0');
INSERT INTO `book` VALUES ('2658ff63-4942-4dcd-bb19-6b3d23e68c62', '03f7f27d-1960-4e08-a9cd-32aba38f8823', '硅谷禁书.epub', 'D:\\BookRepository\\BookStore\\IT\\硅谷禁书.epub', 'D:\\BookRepository\\Pictures\\2658ff63-4942-4dcd-bb19-6b3d23e68c62硅谷禁书.epub.jpg', 'http://book.douban.com/subject_search?search_text=硅谷禁书.epub', '0');
INSERT INTO `book` VALUES ('285c9bf4-d87f-43fd-9f5b-d8e954ada6c6', '1117d65e-a351-46ea-8197-a2d2e6df4161', '《思考的技术》.txt', 'D:\\BookRepository\\BookStore\\方法论\\《思考的技术》.txt', 'D:\\BookRepository\\Pictures\\285c9bf4-d87f-43fd-9f5b-d8e954ada6c6《思考的技术》.txt.jpg', 'http://book.douban.com/subject_search?search_text=《思考的技术》.txt', '0');
INSERT INTO `book` VALUES ('288e058f-9fbb-4230-90cb-282fe00f7871', '2aaa037e-72f9-4be5-90fe-7346f554c380', '资治通鉴全译本（柏杨版）.epub', 'D:\\BookRepository\\BookStore\\历史\\资治通鉴全译本（柏杨版）.epub', 'D:\\BookRepository\\Pictures\\288e058f-9fbb-4230-90cb-282fe00f7871资治通鉴全译本（柏杨版）.epub.jpg', 'http://book.douban.com/subject_search?search_text=资治通鉴全译本（柏杨版）.epub', '0');
INSERT INTO `book` VALUES ('28c4f7e9-278b-41e7-9e4a-973900071d9e', 'be13cd45-fd37-4a96-b855-d99f3416c732', 'The Principles ofPolitical Economy《政治经济学原理》（共五册）.pdf', 'D:\\BookRepository\\BookStore\\经管\\The Principles ofPolitical Economy《政治经济学原理》（共五册）.pdf', null, 'http://book.douban.com/subject_search?search_text=The Principles ofPolitical Economy《政治经济学原理》（共五册）.pdf', '0');
INSERT INTO `book` VALUES ('29680e3a-37f3-4c3d-9846-e79d9452f06c', '6524c87a-ef83-4adc-b652-32348692d696', '[那些年，我们一起追的女孩].九把刀.文字版.pdf', 'D:\\BookRepository\\BookStore\\文学\\小说\\[那些年，我们一起追的女孩].九把刀.文字版.pdf', 'D:\\BookRepository\\Pictures\\29680e3a-37f3-4c3d-9846-e79d9452f06c[那些年，我们一起追的女孩].九把刀.文字版.pdf.jpg', 'http://book.douban.com/subject_search?search_text=[那些年，我们一起追的女孩].九把刀.文字版.pdf', '0');
INSERT INTO `book` VALUES ('2972345b-a33d-4b12-ae93-3fa192a59616', '03f7f27d-1960-4e08-a9cd-32aba38f8823', '腾讯十年真实创业成长史：腾讯十年.epub', 'D:\\BookRepository\\BookStore\\IT\\腾讯十年真实创业成长史：腾讯十年.epub', null, 'http://book.douban.com/subject_search?search_text=腾讯十年真实创业成长史：腾讯十年.epub', '0');
INSERT INTO `book` VALUES ('32b8ea36-6c37-4740-96c3-72b1e93e0c2e', '03f7f27d-1960-4e08-a9cd-32aba38f8823', '人月神话.pdf', 'D:\\BookRepository\\BookStore\\IT\\人月神话.pdf', 'D:\\BookRepository\\Pictures\\32b8ea36-6c37-4740-96c3-72b1e93e0c2e人月神话.pdf.jpg', 'http://book.douban.com/subject_search?search_text=人月神话.pdf', '0');
INSERT INTO `book` VALUES ('32fbc851-5648-4b2a-a64f-ee84f7bb6319', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '异端的权利.epub', 'D:\\BookRepository\\BookStore\\社科\\异端的权利.epub', 'D:\\BookRepository\\Pictures\\32fbc851-5648-4b2a-a64f-ee84f7bb6319异端的权利.epub.jpg', 'http://book.douban.com/subject_search?search_text=异端的权利.epub', '0');
INSERT INTO `book` VALUES ('331dab37-11d0-43d5-98d2-886bc8797842', '6524c87a-ef83-4adc-b652-32348692d696', '教父.epub', 'D:\\BookRepository\\BookStore\\文学\\小说\\教父.epub', 'D:\\BookRepository\\Pictures\\331dab37-11d0-43d5-98d2-886bc8797842教父.epub.jpg', 'http://book.douban.com/subject_search?search_text=教父.epub', '0');
INSERT INTO `book` VALUES ('359732db-29a9-477d-9f51-5da46293e87d', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '文化模式.mobi', 'D:\\BookRepository\\BookStore\\社科\\文化模式.mobi', 'D:\\BookRepository\\Pictures\\359732db-29a9-477d-9f51-5da46293e87d文化模式.mobi.jpg', 'http://book.douban.com/subject_search?search_text=文化模式.mobi', '0');
INSERT INTO `book` VALUES ('36761a17-8f61-407b-9eda-942114bf9456', 'be13cd45-fd37-4a96-b855-d99f3416c732', 'On the Principles ofPolitical Economy and Taxation 《政治经济学及赋税原理》.pdf', 'D:\\BookRepository\\BookStore\\经管\\On the Principles ofPolitical Economy and Taxation 《政治经济学及赋税原理》.pdf', null, 'http://book.douban.com/subject_search?search_text=On the Principles ofPolitical Economy and Taxation 《政治经济学及赋税原理》.pdf', '0');
INSERT INTO `book` VALUES ('37557962-dc86-4237-b153-d09b0ee099bc', '6524c87a-ef83-4adc-b652-32348692d696', '简·爱.pdf', 'D:\\BookRepository\\BookStore\\文学\\小说\\简·爱.pdf', 'D:\\BookRepository\\Pictures\\37557962-dc86-4237-b153-d09b0ee099bc简·爱.pdf.jpg', 'http://book.douban.com/subject_search?search_text=简·爱.pdf', '0');
INSERT INTO `book` VALUES ('38234beb-5855-482b-947c-daf21ead0c6e', '5bc5de06-c349-4077-8766-d6a0d2ff3cb9', '把时间当作朋友.pdf', 'D:\\BookRepository\\BookStore\\时间管理\\把时间当作朋友.pdf', 'D:\\BookRepository\\Pictures\\38234beb-5855-482b-947c-daf21ead0c6e把时间当作朋友.pdf.jpg', 'http://book.douban.com/subject_search?search_text=把时间当作朋友.pdf', '0');
INSERT INTO `book` VALUES ('3ab1bae3-5ab5-4a98-a834-4e8c71d83819', 'ef672de5-ac8f-4106-a3ac-28a4c6799687', '智能简史.pdf', 'D:\\BookRepository\\BookStore\\自然科学\\智能简史.pdf', 'D:\\BookRepository\\Pictures\\3ab1bae3-5ab5-4a98-a834-4e8c71d83819智能简史.pdf.jpg', 'http://book.douban.com/subject_search?search_text=智能简史.pdf', '0');
INSERT INTO `book` VALUES ('3b65d5e5-1aef-4874-b652-012b8d014d4d', '2aaa037e-72f9-4be5-90fe-7346f554c380', '第三帝国的兴亡.epub', 'D:\\BookRepository\\BookStore\\历史\\第三帝国的兴亡.epub', 'D:\\BookRepository\\Pictures\\3b65d5e5-1aef-4874-b652-012b8d014d4d第三帝国的兴亡.epub.jpg', 'http://book.douban.com/subject_search?search_text=第三帝国的兴亡.epub', '0');
INSERT INTO `book` VALUES ('3fe551eb-9495-4d62-ba1c-cbfd6337b75d', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '宽容・房龙.pdf', 'D:\\BookRepository\\BookStore\\社科\\宽容・房龙.pdf', 'D:\\BookRepository\\Pictures\\3fe551eb-9495-4d62-ba1c-cbfd6337b75d宽容・房龙.pdf.jpg', 'http://book.douban.com/subject_search?search_text=宽容・房龙.pdf', '0');
INSERT INTO `book` VALUES ('40fc57f7-a139-4d76-ad67-7d54d4868561', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '道德情操论.epub', 'D:\\BookRepository\\BookStore\\社科\\道德情操论.epub', 'D:\\BookRepository\\Pictures\\40fc57f7-a139-4d76-ad67-7d54d4868561道德情操论.epub.jpg', 'http://book.douban.com/subject_search?search_text=道德情操论.epub', '0');
INSERT INTO `book` VALUES ('42aed31c-6459-40d7-b0b3-07e0d4568f01', '6524c87a-ef83-4adc-b652-32348692d696', '1984.pdf', 'D:\\BookRepository\\BookStore\\文学\\小说\\1984.pdf', 'D:\\BookRepository\\Pictures\\42aed31c-6459-40d7-b0b3-07e0d4568f011984.pdf.jpg', 'http://book.douban.com/subject_search?search_text=1984.pdf', '0');
INSERT INTO `book` VALUES ('43605d33-7cdb-4b36-a775-eb9268c33d04', 'be13cd45-fd37-4a96-b855-d99f3416c732', '蓝海战略_m.epub', 'D:\\BookRepository\\BookStore\\经管\\蓝海战略_m.epub', 'D:\\BookRepository\\Pictures\\43605d33-7cdb-4b36-a775-eb9268c33d04蓝海战略_m.epub.jpg', 'http://book.douban.com/subject_search?search_text=蓝海战略_m.epub', '0');
INSERT INTO `book` VALUES ('44ca5241-d6dc-4c72-9a9b-faf5d03d8c53', '2aaa037e-72f9-4be5-90fe-7346f554c380', '大秦帝国（精排全集）.epub', 'D:\\BookRepository\\BookStore\\历史\\大秦帝国（精排全集）.epub', 'D:\\BookRepository\\Pictures\\44ca5241-d6dc-4c72-9a9b-faf5d03d8c53大秦帝国（精排全集）.epub.jpg', 'http://book.douban.com/subject_search?search_text=大秦帝国（精排全集）.epub', '0');
INSERT INTO `book` VALUES ('497a0ab0-8713-4612-9a46-35ccb0d99e92', 'dfa03605-ce58-435f-956f-9150f8303d90', '[德]黑格尔 - 精神现象学.epub', 'D:\\BookRepository\\BookStore\\哲学\\[德]黑格尔 - 精神现象学.epub', null, 'http://book.douban.com/subject_search?search_text=[德]黑格尔 - 精神现象学.epub', '0');
INSERT INTO `book` VALUES ('49984f44-17c4-45f1-a2a9-120d1315dc72', 'be13cd45-fd37-4a96-b855-d99f3416c732', '伟大的博弈.epub', 'D:\\BookRepository\\BookStore\\经管\\伟大的博弈.epub', 'D:\\BookRepository\\Pictures\\49984f44-17c4-45f1-a2a9-120d1315dc72伟大的博弈.epub.jpg', 'http://book.douban.com/subject_search?search_text=伟大的博弈.epub', '0');
INSERT INTO `book` VALUES ('4beedf83-d538-437e-942a-44d6011a7c1d', 'a16749a3-fc05-48ee-96d4-52c1fc0243ac', '心理控制术.epub', 'D:\\BookRepository\\BookStore\\心理学\\心理控制术.epub', 'D:\\BookRepository\\Pictures\\4beedf83-d538-437e-942a-44d6011a7c1d心理控制术.epub.jpg', 'http://book.douban.com/subject_search?search_text=心理控制术.epub', '0');
INSERT INTO `book` VALUES ('4c8f8d4f-b586-4fa2-a123-7602a6745e20', 'dfa03605-ce58-435f-956f-9150f8303d90', '第二性.epub', 'D:\\BookRepository\\BookStore\\哲学\\第二性.epub', 'D:\\BookRepository\\Pictures\\4c8f8d4f-b586-4fa2-a123-7602a6745e20第二性.epub.jpg', 'http://book.douban.com/subject_search?search_text=第二性.epub', '0');
INSERT INTO `book` VALUES ('4d0b09c8-5615-4f90-95c7-6546b36bebea', '6524c87a-ef83-4adc-b652-32348692d696', '父与子.pdf', 'D:\\BookRepository\\BookStore\\文学\\小说\\父与子.pdf', 'D:\\BookRepository\\Pictures\\4d0b09c8-5615-4f90-95c7-6546b36bebea父与子.pdf.jpg', 'http://book.douban.com/subject_search?search_text=父与子.pdf', '0');
INSERT INTO `book` VALUES ('4d1e8812-2d20-44f6-ab9f-1380c4462de2', '03f7f27d-1960-4e08-a9cd-32aba38f8823', 'Getting+Real中文版.pdf', 'D:\\BookRepository\\BookStore\\IT\\Getting+Real中文版.pdf', null, 'http://book.douban.com/subject_search?search_text=Getting+Real中文版.pdf', '0');
INSERT INTO `book` VALUES ('4e24435c-3458-4f45-b515-61b8b4175f82', '03f7f27d-1960-4e08-a9cd-32aba38f8823', '《数学之美与浪潮之巅》_吴军 著.pdf', 'D:\\BookRepository\\BookStore\\IT\\《数学之美与浪潮之巅》_吴军 著.pdf', null, 'http://book.douban.com/subject_search?search_text=《数学之美与浪潮之巅》_吴军 著.pdf', '0');
INSERT INTO `book` VALUES ('4f7b0d1d-7405-40d9-beb2-256fa7c7b8a3', 'a16749a3-fc05-48ee-96d4-52c1fc0243ac', '性心理学.pdf', 'D:\\BookRepository\\BookStore\\心理学\\性心理学.pdf', 'D:\\BookRepository\\Pictures\\4f7b0d1d-7405-40d9-beb2-256fa7c7b8a3性心理学.pdf.jpg', 'http://book.douban.com/subject_search?search_text=性心理学.pdf', '0');
INSERT INTO `book` VALUES ('4fb12fd9-1b3a-4d11-83f2-845b3fe922d3', 'dfa03605-ce58-435f-956f-9150f8303d90', '查拉斯图拉如是说.epub', 'D:\\BookRepository\\BookStore\\哲学\\查拉斯图拉如是说.epub', 'D:\\BookRepository\\Pictures\\4fb12fd9-1b3a-4d11-83f2-845b3fe922d3查拉斯图拉如是说.epub.jpg', 'http://book.douban.com/subject_search?search_text=查拉斯图拉如是说.epub', '0');
INSERT INTO `book` VALUES ('507900de-0ade-45d9-8d0a-a8b006bce40c', '03f7f27d-1960-4e08-a9cd-32aba38f8823', '重来 REWORK.pdf', 'D:\\BookRepository\\BookStore\\IT\\重来 REWORK.pdf', 'D:\\BookRepository\\Pictures\\507900de-0ade-45d9-8d0a-a8b006bce40c重来 REWORK.pdf.jpg', 'http://book.douban.com/subject_search?search_text=重来 REWORK.pdf', '0');
INSERT INTO `book` VALUES ('522eb1ec-6b70-4f4f-8f62-32bdfbd3a24e', '03f7f27d-1960-4e08-a9cd-32aba38f8823', '浪潮之巅.mobi', 'D:\\BookRepository\\BookStore\\IT\\浪潮之巅.mobi', 'D:\\BookRepository\\Pictures\\522eb1ec-6b70-4f4f-8f62-32bdfbd3a24e浪潮之巅.mobi.jpg', 'http://book.douban.com/subject_search?search_text=浪潮之巅.mobi', '0');
INSERT INTO `book` VALUES ('5b0458e9-3207-431b-ac0c-ca171217fc2e', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '人的条件.epub', 'D:\\BookRepository\\BookStore\\社科\\人的条件.epub', 'D:\\BookRepository\\Pictures\\5b0458e9-3207-431b-ac0c-ca171217fc2e人的条件.epub.jpg', 'http://book.douban.com/subject_search?search_text=人的条件.epub', '0');
INSERT INTO `book` VALUES ('5de78f29-b36f-475c-bd30-06afd1281ed7', '6524c87a-ef83-4adc-b652-32348692d696', '战争与和平（上）.pdf', 'D:\\BookRepository\\BookStore\\文学\\小说\\战争与和平（上）.pdf', 'D:\\BookRepository\\Pictures\\5de78f29-b36f-475c-bd30-06afd1281ed7战争与和平（上）.pdf.jpg', 'http://book.douban.com/subject_search?search_text=战争与和平（上）.pdf', '0');
INSERT INTO `book` VALUES ('5e023546-374b-4159-bf47-5f1c56eeca85', '2aaa037e-72f9-4be5-90fe-7346f554c380', '美国种族简史.pdf', 'D:\\BookRepository\\BookStore\\历史\\美国种族简史.pdf', 'D:\\BookRepository\\Pictures\\5e023546-374b-4159-bf47-5f1c56eeca85美国种族简史.pdf.jpg', 'http://book.douban.com/subject_search?search_text=美国种族简史.pdf', '0');
INSERT INTO `book` VALUES ('62609e8b-64a9-4330-bc06-878dfc794fa8', '6524c87a-ef83-4adc-b652-32348692d696', '舒克和贝塔全传.epub', 'D:\\BookRepository\\BookStore\\文学\\小说\\舒克和贝塔全传.epub', 'D:\\BookRepository\\Pictures\\62609e8b-64a9-4330-bc06-878dfc794fa8舒克和贝塔全传.epub.jpg', 'http://book.douban.com/subject_search?search_text=舒克和贝塔全传.epub', '0');
INSERT INTO `book` VALUES ('644a8f9c-f7a2-4c8b-a92c-f54e7b11dc92', '2aaa037e-72f9-4be5-90fe-7346f554c380', '伯罗奔尼撒战争史.pdf', 'D:\\BookRepository\\BookStore\\历史\\伯罗奔尼撒战争史.pdf', 'D:\\BookRepository\\Pictures\\644a8f9c-f7a2-4c8b-a92c-f54e7b11dc92伯罗奔尼撒战争史.pdf.jpg', 'http://book.douban.com/subject_search?search_text=伯罗奔尼撒战争史.pdf', '0');
INSERT INTO `book` VALUES ('657d7b2d-e22e-4e71-9791-2c2e1b23602c', '9f4411f1-ba98-4197-a444-dcd97f129028', '川端康成作品集.pdf', 'D:\\BookRepository\\BookStore\\文学\\杂文\\川端康成作品集.pdf', 'D:\\BookRepository\\Pictures\\657d7b2d-e22e-4e71-9791-2c2e1b23602c川端康成作品集.pdf.jpg', 'http://book.douban.com/subject_search?search_text=川端康成作品集.pdf', '0');
INSERT INTO `book` VALUES ('66b2d9fd-4809-4fd5-acc1-6a15223e9524', '6524c87a-ef83-4adc-b652-32348692d696', '高老头.pdf', 'D:\\BookRepository\\BookStore\\文学\\小说\\高老头.pdf', 'D:\\BookRepository\\Pictures\\66b2d9fd-4809-4fd5-acc1-6a15223e9524高老头.pdf.jpg', 'http://book.douban.com/subject_search?search_text=高老头.pdf', '0');
INSERT INTO `book` VALUES ('68ae0fff-0962-4a45-8f5b-d40566a5151f', 'ef672de5-ac8f-4106-a3ac-28a4c6799687', '皇帝的新脑.pdf', 'D:\\BookRepository\\BookStore\\自然科学\\皇帝的新脑.pdf', 'D:\\BookRepository\\Pictures\\68ae0fff-0962-4a45-8f5b-d40566a5151f皇帝的新脑.pdf.jpg', 'http://book.douban.com/subject_search?search_text=皇帝的新脑.pdf', '0');
INSERT INTO `book` VALUES ('692cbd2a-f717-4472-a529-aaa6fb798894', '6524c87a-ef83-4adc-b652-32348692d696', '百年孤独.pdf', 'D:\\BookRepository\\BookStore\\文学\\小说\\百年孤独.pdf', 'D:\\BookRepository\\Pictures\\692cbd2a-f717-4472-a529-aaa6fb798894百年孤独.pdf.jpg', 'http://book.douban.com/subject_search?search_text=百年孤独.pdf', '0');
INSERT INTO `book` VALUES ('692d756c-32b1-4f08-8930-cff768f48672', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '近距离看美国（全集）.epub', 'D:\\BookRepository\\BookStore\\社科\\近距离看美国（全集）.epub', 'D:\\BookRepository\\Pictures\\692d756c-32b1-4f08-8930-cff768f48672近距离看美国（全集）.epub.jpg', 'http://book.douban.com/subject_search?search_text=近距离看美国（全集）.epub', '0');
INSERT INTO `book` VALUES ('6ba29c82-3080-45f1-a0fa-be8ef4c9acc2', '6524c87a-ef83-4adc-b652-32348692d696', '第二十二条军规.epub', 'D:\\BookRepository\\BookStore\\文学\\小说\\第二十二条军规.epub', 'D:\\BookRepository\\Pictures\\6ba29c82-3080-45f1-a0fa-be8ef4c9acc2第二十二条军规.epub.jpg', 'http://book.douban.com/subject_search?search_text=第二十二条军规.epub', '0');
INSERT INTO `book` VALUES ('6d4b8a96-c99c-4d90-802a-0b6d7ecb5a98', '7d8e46e6-11c2-4002-af08-cff21fb0fc63', '正则表达式30分钟入门教程.pdf', 'D:\\BookRepository\\BookStore\\CS\\正则表达式30分钟入门教程.pdf', 'D:\\BookRepository\\Pictures\\6d4b8a96-c99c-4d90-802a-0b6d7ecb5a98正则表达式30分钟入门教程.pdf.jpg', 'http://book.douban.com/subject_search?search_text=正则表达式30分钟入门教程.pdf', '0');
INSERT INTO `book` VALUES ('6e7150ad-8b3b-4a6d-a6e2-89e1dff61e92', '2aaa037e-72f9-4be5-90fe-7346f554c380', '万历十五年-黄仁宇.mobi', 'D:\\BookRepository\\BookStore\\历史\\万历十五年-黄仁宇.mobi', 'D:\\BookRepository\\Pictures\\6e7150ad-8b3b-4a6d-a6e2-89e1dff61e92万历十五年-黄仁宇.mobi.jpg', 'http://book.douban.com/subject_search?search_text=万历十五年-黄仁宇.mobi', '0');
INSERT INTO `book` VALUES ('7022c753-0f78-47c7-9bb3-90598a8f4d1d', '78769aeb-c098-4a34-b453-ef869e43d2d6', '荷马史诗.pdf', 'D:\\BookRepository\\BookStore\\文学\\荷马史诗.pdf', 'D:\\BookRepository\\Pictures\\7022c753-0f78-47c7-9bb3-90598a8f4d1d荷马史诗.pdf.jpg', 'http://book.douban.com/subject_search?search_text=荷马史诗.pdf', '0');
INSERT INTO `book` VALUES ('71f81bcc-42de-4f56-924b-5f7516560dbb', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '[国富论].亚当·斯密.(Adam.Smith).唐日松.译.文字版.epub', 'D:\\BookRepository\\BookStore\\社科\\[国富论].亚当·斯密.(Adam.Smith).唐日松.译.文字版.epub', null, 'http://book.douban.com/subject_search?search_text=[国富论].亚当·斯密.(Adam.Smith).唐日松.译.文字版.epub', '0');
INSERT INTO `book` VALUES ('721c674d-eeba-4c63-bb29-fdefc3739b14', 'be13cd45-fd37-4a96-b855-d99f3416c732', '经济学原理：微观经济学分册.第5版.（美）曼昆.pdf', 'D:\\BookRepository\\BookStore\\经管\\经济学原理：微观经济学分册.第5版.（美）曼昆.pdf', 'D:\\BookRepository\\Pictures\\721c674d-eeba-4c63-bb29-fdefc3739b14经济学原理：微观经济学分册.第5版.（美）曼昆.pdf.jpg', 'http://book.douban.com/subject_search?search_text=经济学原理：微观经济学分册.第5版.（美）曼昆.pdf', '0');
INSERT INTO `book` VALUES ('737d4c74-a603-4b78-88e1-bd51abec6f0d', '03f7f27d-1960-4e08-a9cd-32aba38f8823', '失控：机器、社会与经济的新生物学-凯文·凯利.mobi', 'D:\\BookRepository\\BookStore\\IT\\失控：机器、社会与经济的新生物学-凯文·凯利.mobi', 'D:\\BookRepository\\Pictures\\737d4c74-a603-4b78-88e1-bd51abec6f0d失控：机器、社会与经济的新生物学-凯文·凯利.mobi.jpg', 'http://book.douban.com/subject_search?search_text=失控：机器、社会与经济的新生物学-凯文·凯利.mobi', '0');
INSERT INTO `book` VALUES ('73cc9452-6313-455d-ad53-f1b73056caab', '001f13cd-0bbc-4691-8e0b-69cccce27982', '禅与维修摩托车的艺术_罗伯特-M-波西格.pdf', 'D:\\BookRepository\\BookStore\\修炼\\禅与维修摩托车的艺术_罗伯特-M-波西格.pdf', 'D:\\BookRepository\\Pictures\\73cc9452-6313-455d-ad53-f1b73056caab禅与维修摩托车的艺术_罗伯特-M-波西格.pdf.jpg', 'http://book.douban.com/subject_search?search_text=禅与维修摩托车的艺术_罗伯特-M-波西格.pdf', '0');
INSERT INTO `book` VALUES ('73d45b9c-1e84-405b-893c-1903ac7a6647', '6524c87a-ef83-4adc-b652-32348692d696', '美丽新世界.epub', 'D:\\BookRepository\\BookStore\\文学\\小说\\美丽新世界.epub', 'D:\\BookRepository\\Pictures\\73d45b9c-1e84-405b-893c-1903ac7a6647美丽新世界.epub.jpg', 'http://book.douban.com/subject_search?search_text=美丽新世界.epub', '0');
INSERT INTO `book` VALUES ('7444d5d0-2966-45a6-a310-eb70600fa9dc', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '正义论.epub', 'D:\\BookRepository\\BookStore\\社科\\正义论.epub', 'D:\\BookRepository\\Pictures\\7444d5d0-2966-45a6-a310-eb70600fa9dc正义论.epub.jpg', 'http://book.douban.com/subject_search?search_text=正义论.epub', '0');
INSERT INTO `book` VALUES ('744bd124-7455-44ed-bca0-aa775ba2c914', '6524c87a-ef83-4adc-b652-32348692d696', '基督山伯爵.epub', 'D:\\BookRepository\\BookStore\\文学\\小说\\基督山伯爵.epub', 'D:\\BookRepository\\Pictures\\744bd124-7455-44ed-bca0-aa775ba2c914基督山伯爵.epub.jpg', 'http://book.douban.com/subject_search?search_text=基督山伯爵.epub', '0');
INSERT INTO `book` VALUES ('761698a3-ca07-4293-8c87-97c37e680b0e', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '[常识].梁文道.文字版.epub', 'D:\\BookRepository\\BookStore\\社科\\[常识].梁文道.文字版.epub', 'D:\\BookRepository\\Pictures\\761698a3-ca07-4293-8c87-97c37e680b0e[常识].梁文道.文字版.epub.jpg', 'http://book.douban.com/subject_search?search_text=[常识].梁文道.文字版.epub', '0');
INSERT INTO `book` VALUES ('7777ccec-d9cc-4411-a1be-244c637bd8c5', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '狂热分子.epub', 'D:\\BookRepository\\BookStore\\社科\\狂热分子.epub', 'D:\\BookRepository\\Pictures\\7777ccec-d9cc-4411-a1be-244c637bd8c5狂热分子.epub.jpg', 'http://book.douban.com/subject_search?search_text=狂热分子.epub', '0');
INSERT INTO `book` VALUES ('77898f30-6593-4e72-a02f-cb5c8f022927', '1117d65e-a351-46ea-8197-a2d2e6df4161', '第五项修炼-彼德・圣吉.pdf', 'D:\\BookRepository\\BookStore\\方法论\\第五项修炼-彼德・圣吉.pdf', 'D:\\BookRepository\\Pictures\\77898f30-6593-4e72-a02f-cb5c8f022927第五项修炼-彼德・圣吉.pdf.jpg', 'http://book.douban.com/subject_search?search_text=第五项修炼-彼德・圣吉.pdf', '0');
INSERT INTO `book` VALUES ('79abb815-d043-4d59-9f7c-a4bd3be38ec0', '2aaa037e-72f9-4be5-90fe-7346f554c380', '剑桥中华民国史下.pdf', 'D:\\BookRepository\\BookStore\\历史\\剑桥中华民国史下.pdf', 'D:\\BookRepository\\Pictures\\79abb815-d043-4d59-9f7c-a4bd3be38ec0剑桥中华民国史下.pdf.jpg', 'http://book.douban.com/subject_search?search_text=剑桥中华民国史下.pdf', '0');
INSERT INTO `book` VALUES ('79ea3144-9081-4f17-934b-e4a92a69a580', '2aaa037e-72f9-4be5-90fe-7346f554c380', '巨流河.epub', 'D:\\BookRepository\\BookStore\\历史\\巨流河.epub', 'D:\\BookRepository\\Pictures\\79ea3144-9081-4f17-934b-e4a92a69a580巨流河.epub.jpg', 'http://book.douban.com/subject_search?search_text=巨流河.epub', '0');
INSERT INTO `book` VALUES ('7b7fee7e-1e83-426e-8749-39b1534d98c2', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '民主的细节.mobi', 'D:\\BookRepository\\BookStore\\社科\\民主的细节.mobi', 'D:\\BookRepository\\Pictures\\7b7fee7e-1e83-426e-8749-39b1534d98c2民主的细节.mobi.jpg', 'http://book.douban.com/subject_search?search_text=民主的细节.mobi', '0');
INSERT INTO `book` VALUES ('7c1b0be6-3079-4c21-86ae-3a5fa3747256', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '野火集.epub', 'D:\\BookRepository\\BookStore\\社科\\野火集.epub', 'D:\\BookRepository\\Pictures\\7c1b0be6-3079-4c21-86ae-3a5fa3747256野火集.epub.jpg', 'http://book.douban.com/subject_search?search_text=野火集.epub', '0');
INSERT INTO `book` VALUES ('7e581cc2-968c-486b-a4ba-bcf4b411b71e', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '战争论_文字版PDF_4f9329f1.pdf', 'D:\\BookRepository\\BookStore\\社科\\战争论_文字版PDF_4f9329f1.pdf', null, 'http://book.douban.com/subject_search?search_text=战争论_文字版PDF_4f9329f1.pdf', '0');
INSERT INTO `book` VALUES ('7f41cdb2-dfeb-407b-9f1e-057697a4d131', 'a16749a3-fc05-48ee-96d4-52c1fc0243ac', '怪诞心理学.epub', 'D:\\BookRepository\\BookStore\\心理学\\怪诞心理学.epub', 'D:\\BookRepository\\Pictures\\7f41cdb2-dfeb-407b-9f1e-057697a4d131怪诞心理学.epub.jpg', 'http://book.douban.com/subject_search?search_text=怪诞心理学.epub', '0');
INSERT INTO `book` VALUES ('80b86ec7-6143-4d49-af93-1bef529306d2', 'be13cd45-fd37-4a96-b855-d99f3416c732', '茅于轼 给你所爱的人以自由.pdf', 'D:\\BookRepository\\BookStore\\经管\\茅于轼 给你所爱的人以自由.pdf', 'D:\\BookRepository\\Pictures\\80b86ec7-6143-4d49-af93-1bef529306d2茅于轼 给你所爱的人以自由.pdf.jpg', 'http://book.douban.com/subject_search?search_text=茅于轼 给你所爱的人以自由.pdf', '0');
INSERT INTO `book` VALUES ('82ba349c-5971-4688-94fb-458ca3fe6593', 'ef672de5-ac8f-4106-a3ac-28a4c6799687', '万物简史.pdf', 'D:\\BookRepository\\BookStore\\自然科学\\万物简史.pdf', 'D:\\BookRepository\\Pictures\\82ba349c-5971-4688-94fb-458ca3fe6593万物简史.pdf.jpg', 'http://book.douban.com/subject_search?search_text=万物简史.pdf', '0');
INSERT INTO `book` VALUES ('84f77ab0-9f69-4a42-bd10-0e9adfe39da3', '001f13cd-0bbc-4691-8e0b-69cccce27982', '新东方GRE词汇精选.epub', 'D:\\BookRepository\\BookStore\\修炼\\新东方GRE词汇精选.epub', 'D:\\BookRepository\\Pictures\\84f77ab0-9f69-4a42-bd10-0e9adfe39da3新东方GRE词汇精选.epub.jpg', 'http://book.douban.com/subject_search?search_text=新东方GRE词汇精选.epub', '0');
INSERT INTO `book` VALUES ('854e7cdb-1598-4e6e-bff3-ff4ed3d52b7e', 'be13cd45-fd37-4a96-b855-d99f3416c732', '干掉一切对手-看高盛如何算赢世界-1291719722190.epub', 'D:\\BookRepository\\BookStore\\经管\\干掉一切对手-看高盛如何算赢世界-1291719722190.epub', null, 'http://book.douban.com/subject_search?search_text=干掉一切对手-看高盛如何算赢世界-1291719722190.epub', '0');
INSERT INTO `book` VALUES ('88d9797e-76b3-4477-9861-ef2d5034aa2c', '5bc5de06-c349-4077-8766-d6a0d2ff3cb9', '番茄工作法.pdf', 'D:\\BookRepository\\BookStore\\时间管理\\番茄工作法.pdf', 'D:\\BookRepository\\Pictures\\88d9797e-76b3-4477-9861-ef2d5034aa2c番茄工作法.pdf.jpg', 'http://book.douban.com/subject_search?search_text=番茄工作法.pdf', '0');
INSERT INTO `book` VALUES ('893998ae-5856-4250-8720-be931605e9e9', '03f7f27d-1960-4e08-a9cd-32aba38f8823', '思科九年.epub', 'D:\\BookRepository\\BookStore\\IT\\思科九年.epub', 'D:\\BookRepository\\Pictures\\893998ae-5856-4250-8720-be931605e9e9思科九年.epub.jpg', 'http://book.douban.com/subject_search?search_text=思科九年.epub', '0');
INSERT INTO `book` VALUES ('89728ea4-2b6f-4960-9f2d-a9b482717238', 'dfa03605-ce58-435f-956f-9150f8303d90', '瓦尔登湖.pdf', 'D:\\BookRepository\\BookStore\\哲学\\瓦尔登湖.pdf', 'D:\\BookRepository\\Pictures\\89728ea4-2b6f-4960-9f2d-a9b482717238瓦尔登湖.pdf.jpg', 'http://book.douban.com/subject_search?search_text=瓦尔登湖.pdf', '0');
INSERT INTO `book` VALUES ('8a42c92f-5c3a-4801-81e9-e52d8e43f8be', '7d8e46e6-11c2-4002-af08-cff21fb0fc63', 'Dive_into_python_zh-CN.pdf', 'D:\\BookRepository\\BookStore\\CS\\Dive_into_python_zh-CN.pdf', 'D:\\BookRepository\\Pictures\\8a42c92f-5c3a-4801-81e9-e52d8e43f8beDive_into_python_zh-CN.pdf.jpg', 'http://book.douban.com/subject_search?search_text=Dive_into_python_zh-CN.pdf', '0');
INSERT INTO `book` VALUES ('8a67b31a-0817-45d7-b7f3-5c3cc9eb7d3a', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '旧制度与大革命.mobi', 'D:\\BookRepository\\BookStore\\社科\\旧制度与大革命.mobi', 'D:\\BookRepository\\Pictures\\8a67b31a-0817-45d7-b7f3-5c3cc9eb7d3a旧制度与大革命.mobi.jpg', 'http://book.douban.com/subject_search?search_text=旧制度与大革命.mobi', '0');
INSERT INTO `book` VALUES ('8aaf0632-53aa-4285-a60b-2e9ffc7bee6f', '2aaa037e-72f9-4be5-90fe-7346f554c380', '告诉你一个真实的汪精卫.pdf', 'D:\\BookRepository\\BookStore\\历史\\告诉你一个真实的汪精卫.pdf', 'D:\\BookRepository\\Pictures\\8aaf0632-53aa-4285-a60b-2e9ffc7bee6f告诉你一个真实的汪精卫.pdf.jpg', 'http://book.douban.com/subject_search?search_text=告诉你一个真实的汪精卫.pdf', '0');
INSERT INTO `book` VALUES ('8aeea61b-35f3-4444-911b-e4740a669b22', '1117d65e-a351-46ea-8197-a2d2e6df4161', '统计数字会撒谎.epub', 'D:\\BookRepository\\BookStore\\方法论\\统计数字会撒谎.epub', 'D:\\BookRepository\\Pictures\\8aeea61b-35f3-4444-911b-e4740a669b22统计数字会撒谎.epub.jpg', 'http://book.douban.com/subject_search?search_text=统计数字会撒谎.epub', '0');
INSERT INTO `book` VALUES ('8c580e76-1047-4acb-aa66-9eb1ddf025cb', '03f7f27d-1960-4e08-a9cd-32aba38f8823', '众包.pdf', 'D:\\BookRepository\\BookStore\\IT\\众包.pdf', 'D:\\BookRepository\\Pictures\\8c580e76-1047-4acb-aa66-9eb1ddf025cb众包.pdf.jpg', 'http://book.douban.com/subject_search?search_text=众包.pdf', '0');
INSERT INTO `book` VALUES ('8c96f41c-ba0e-4f17-9b13-e00641507dcd', '6524c87a-ef83-4adc-b652-32348692d696', '唐吉诃德.epub', 'D:\\BookRepository\\BookStore\\文学\\小说\\唐吉诃德.epub', 'D:\\BookRepository\\Pictures\\8c96f41c-ba0e-4f17-9b13-e00641507dcd唐吉诃德.epub.jpg', 'http://book.douban.com/subject_search?search_text=唐吉诃德.epub', '0');
INSERT INTO `book` VALUES ('8ee51a51-bb8b-427c-823f-0799303ba0d7', 'be13cd45-fd37-4a96-b855-d99f3416c732', '魔鬼经济学.epub', 'D:\\BookRepository\\BookStore\\经管\\魔鬼经济学.epub', 'D:\\BookRepository\\Pictures\\8ee51a51-bb8b-427c-823f-0799303ba0d7魔鬼经济学.epub.jpg', 'http://book.douban.com/subject_search?search_text=魔鬼经济学.epub', '0');
INSERT INTO `book` VALUES ('93a3dbb0-e137-4484-9064-29eb291937fb', 'dfa03605-ce58-435f-956f-9150f8303d90', '忏悔录.epub', 'D:\\BookRepository\\BookStore\\哲学\\忏悔录.epub', 'D:\\BookRepository\\Pictures\\93a3dbb0-e137-4484-9064-29eb291937fb忏悔录.epub.jpg', 'http://book.douban.com/subject_search?search_text=忏悔录.epub', '0');
INSERT INTO `book` VALUES ('93a4bbf7-0687-46f2-8733-0e45380c63d4', 'ef672de5-ac8f-4106-a3ac-28a4c6799687', '科学发现的逻辑karl.pdf', 'D:\\BookRepository\\BookStore\\自然科学\\科学发现的逻辑karl.pdf', 'D:\\BookRepository\\Pictures\\93a4bbf7-0687-46f2-8733-0e45380c63d4科学发现的逻辑karl.pdf.jpg', 'http://book.douban.com/subject_search?search_text=科学发现的逻辑karl.pdf', '0');
INSERT INTO `book` VALUES ('954519c5-f690-428b-af6e-6aeb6a0066c7', '6524c87a-ef83-4adc-b652-32348692d696', '莫泊桑短篇小说精选集.epub', 'D:\\BookRepository\\BookStore\\文学\\小说\\莫泊桑短篇小说精选集.epub', 'D:\\BookRepository\\Pictures\\954519c5-f690-428b-af6e-6aeb6a0066c7莫泊桑短篇小说精选集.epub.jpg', 'http://book.douban.com/subject_search?search_text=莫泊桑短篇小说精选集.epub', '0');
INSERT INTO `book` VALUES ('96214ebf-5bef-46bb-9ed3-374b8cdd2478', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '自私的基因.mobi', 'D:\\BookRepository\\BookStore\\社科\\自私的基因.mobi', 'D:\\BookRepository\\Pictures\\96214ebf-5bef-46bb-9ed3-374b8cdd2478自私的基因.mobi.jpg', 'http://book.douban.com/subject_search?search_text=自私的基因.mobi', '0');
INSERT INTO `book` VALUES ('967f80df-32b6-4ea8-bbdc-7432bddeaff3', 'b9980d8f-36e6-4740-8d97-0d6c81674cce', '穆斯林的葬礼.epub', 'D:\\BookRepository\\BookStore\\文学\\纪实\\穆斯林的葬礼.epub', 'D:\\BookRepository\\Pictures\\967f80df-32b6-4ea8-bbdc-7432bddeaff3穆斯林的葬礼.epub.jpg', 'http://book.douban.com/subject_search?search_text=穆斯林的葬礼.epub', '0');
INSERT INTO `book` VALUES ('9bad2653-c785-4254-b993-969568164644', '9f4411f1-ba98-4197-a444-dcd97f129028', '王朔文集.epub', 'D:\\BookRepository\\BookStore\\文学\\杂文\\王朔文集.epub', 'D:\\BookRepository\\Pictures\\9bad2653-c785-4254-b993-969568164644王朔文集.epub.jpg', 'http://book.douban.com/subject_search?search_text=王朔文集.epub', '0');
INSERT INTO `book` VALUES ('9c5db8ef-caa2-47cf-abc9-4bb0acd2ee80', 'b9980d8f-36e6-4740-8d97-0d6c81674cce', '菊与刀.epub', 'D:\\BookRepository\\BookStore\\文学\\纪实\\菊与刀.epub', 'D:\\BookRepository\\Pictures\\9c5db8ef-caa2-47cf-abc9-4bb0acd2ee80菊与刀.epub.jpg', 'http://book.douban.com/subject_search?search_text=菊与刀.epub', '0');
INSERT INTO `book` VALUES ('9fcc9b3a-1a12-40fb-ac7a-461f23580d6a', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '文明论概略.mobi', 'D:\\BookRepository\\BookStore\\社科\\文明论概略.mobi', 'D:\\BookRepository\\Pictures\\9fcc9b3a-1a12-40fb-ac7a-461f23580d6a文明论概略.mobi.jpg', 'http://book.douban.com/subject_search?search_text=文明论概略.mobi', '0');
INSERT INTO `book` VALUES ('a68bd13a-d9a1-442d-97d9-c5b641c275d2', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '自由、市场与国家.mobi', 'D:\\BookRepository\\BookStore\\社科\\自由、市场与国家.mobi', 'D:\\BookRepository\\Pictures\\a68bd13a-d9a1-442d-97d9-c5b641c275d2自由、市场与国家.mobi.jpg', 'http://book.douban.com/subject_search?search_text=自由、市场与国家.mobi', '0');
INSERT INTO `book` VALUES ('acf0f0db-13eb-4f91-a4ee-97f845b99b12', 'be13cd45-fd37-4a96-b855-d99f3416c732', '世界是平的-.epub', 'D:\\BookRepository\\BookStore\\经管\\世界是平的-.epub', 'D:\\BookRepository\\Pictures\\acf0f0db-13eb-4f91-a4ee-97f845b99b12世界是平的-.epub.jpg', 'http://book.douban.com/subject_search?search_text=世界是平的-.epub', '0');
INSERT INTO `book` VALUES ('ae5f0d97-6944-42e0-b7be-5715f661d5fb', 'be13cd45-fd37-4a96-b855-d99f3416c732', '金融的逻辑.epub', 'D:\\BookRepository\\BookStore\\经管\\金融的逻辑.epub', 'D:\\BookRepository\\Pictures\\ae5f0d97-6944-42e0-b7be-5715f661d5fb金融的逻辑.epub.jpg', 'http://book.douban.com/subject_search?search_text=金融的逻辑.epub', '0');
INSERT INTO `book` VALUES ('af25e281-b0a6-41c1-b382-78e9098d5191', 'dfa03605-ce58-435f-956f-9150f8303d90', '纯粹理性批判.epub', 'D:\\BookRepository\\BookStore\\哲学\\纯粹理性批判.epub', 'D:\\BookRepository\\Pictures\\af25e281-b0a6-41c1-b382-78e9098d5191纯粹理性批判.epub.jpg', 'http://book.douban.com/subject_search?search_text=纯粹理性批判.epub', '0');
INSERT INTO `book` VALUES ('b4474e9c-48d3-4d52-8762-4b53fdc6df98', 'a16749a3-fc05-48ee-96d4-52c1fc0243ac', '潜意识操控术.epub', 'D:\\BookRepository\\BookStore\\心理学\\潜意识操控术.epub', 'D:\\BookRepository\\Pictures\\b4474e9c-48d3-4d52-8762-4b53fdc6df98潜意识操控术.epub.jpg', 'http://book.douban.com/subject_search?search_text=潜意识操控术.epub', '0');
INSERT INTO `book` VALUES ('b4615cb3-d0b3-417b-8423-11d5e2a408e4', '7d8e46e6-11c2-4002-af08-cff21fb0fc63', '香农_《信息论》_中译版.pdf', 'D:\\BookRepository\\BookStore\\CS\\香农_《信息论》_中译版.pdf', 'D:\\BookRepository\\Pictures\\b4615cb3-d0b3-417b-8423-11d5e2a408e4香农_《信息论》_中译版.pdf.jpg', 'http://book.douban.com/subject_search?search_text=香农_《信息论》_中译版.pdf', '0');
INSERT INTO `book` VALUES ('b532704a-78b2-4869-a2e6-e8f900c5e4fe', '6524c87a-ef83-4adc-b652-32348692d696', '巴黎圣母院.pdf', 'D:\\BookRepository\\BookStore\\文学\\小说\\巴黎圣母院.pdf', 'D:\\BookRepository\\Pictures\\b532704a-78b2-4869-a2e6-e8f900c5e4fe巴黎圣母院.pdf.jpg', 'http://book.douban.com/subject_search?search_text=巴黎圣母院.pdf', '0');
INSERT INTO `book` VALUES ('b76ba84c-e07d-4584-91dc-8ddd073517cb', 'be13cd45-fd37-4a96-b855-d99f3416c732', '决策与判断.epub', 'D:\\BookRepository\\BookStore\\经管\\决策与判断.epub', 'D:\\BookRepository\\Pictures\\b76ba84c-e07d-4584-91dc-8ddd073517cb决策与判断.epub.jpg', 'http://book.douban.com/subject_search?search_text=决策与判断.epub', '0');
INSERT INTO `book` VALUES ('b8a378b5-aab1-48d5-b389-3870d31e26a6', 'be13cd45-fd37-4a96-b855-d99f3416c732', 'The Principles ofScientific Management《泰勒科学管理原理》.pdf', 'D:\\BookRepository\\BookStore\\经管\\The Principles ofScientific Management《泰勒科学管理原理》.pdf', null, 'http://book.douban.com/subject_search?search_text=The Principles ofScientific Management《泰勒科学管理原理》.pdf', '0');
INSERT INTO `book` VALUES ('ba9498e7-0e51-4565-a5da-ecc95034c9c8', 'a16749a3-fc05-48ee-96d4-52c1fc0243ac', '怪诞行为学.pdf', 'D:\\BookRepository\\BookStore\\心理学\\怪诞行为学.pdf', 'D:\\BookRepository\\Pictures\\ba9498e7-0e51-4565-a5da-ecc95034c9c8怪诞行为学.pdf.jpg', 'http://book.douban.com/subject_search?search_text=怪诞行为学.pdf', '0');
INSERT INTO `book` VALUES ('bbad4f59-12d5-45a7-930b-81834e879569', '6524c87a-ef83-4adc-b652-32348692d696', '战争与和平（下）.pdf', 'D:\\BookRepository\\BookStore\\文学\\小说\\战争与和平（下）.pdf', 'D:\\BookRepository\\Pictures\\bbad4f59-12d5-45a7-930b-81834e879569战争与和平（下）.pdf.jpg', 'http://book.douban.com/subject_search?search_text=战争与和平（下）.pdf', '0');
INSERT INTO `book` VALUES ('bc8cb7b8-f047-4e1b-80ad-f12b35e18e5e', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '法学总论.mobi', 'D:\\BookRepository\\BookStore\\社科\\法学总论.mobi', 'D:\\BookRepository\\Pictures\\bc8cb7b8-f047-4e1b-80ad-f12b35e18e5e法学总论.mobi.jpg', 'http://book.douban.com/subject_search?search_text=法学总论.mobi', '0');
INSERT INTO `book` VALUES ('bd6b133e-c447-445e-ae72-d2026cdc9193', '03f7f27d-1960-4e08-a9cd-32aba38f8823', '[史蒂夫·乔布斯传].(Steve.Jobs).Walter.Isaacson.文字版.epub', 'D:\\BookRepository\\BookStore\\IT\\[史蒂夫·乔布斯传].(Steve.Jobs).Walter.Isaacson.文字版.epub', 'D:\\BookRepository\\Pictures\\bd6b133e-c447-445e-ae72-d2026cdc9193[史蒂夫·乔布斯传].(Steve.Jobs).Walter.Isaacson.文字版.epub.jpg', 'http://book.douban.com/subject_search?search_text=[史蒂夫·乔布斯传].(Steve.Jobs).Walter.Isaacson.文字版.epub', '0');
INSERT INTO `book` VALUES ('be1c66fc-fcc3-485a-91fe-c4c0ab270aa7', '2aaa037e-72f9-4be5-90fe-7346f554c380', '红太阳是怎样升起的——延安整风的来龙去脉.pdf', 'D:\\BookRepository\\BookStore\\历史\\红太阳是怎样升起的——延安整风的来龙去脉.pdf', 'D:\\BookRepository\\Pictures\\be1c66fc-fcc3-485a-91fe-c4c0ab270aa7红太阳是怎样升起的——延安整风的来龙去脉.pdf.jpg', 'http://book.douban.com/subject_search?search_text=红太阳是怎样升起的——延安整风的来龙去脉.pdf', '0');
INSERT INTO `book` VALUES ('beee8e59-287e-47ca-bf49-9aa9706892c6', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '自由秩序原理.mobi', 'D:\\BookRepository\\BookStore\\社科\\自由秩序原理.mobi', 'D:\\BookRepository\\Pictures\\beee8e59-287e-47ca-bf49-9aa9706892c6自由秩序原理.mobi.jpg', 'http://book.douban.com/subject_search?search_text=自由秩序原理.mobi', '0');
INSERT INTO `book` VALUES ('c1f85c53-48b9-405e-833e-3e16aad7f591', 'dfa03605-ce58-435f-956f-9150f8303d90', '西方哲学史.epub', 'D:\\BookRepository\\BookStore\\哲学\\西方哲学史.epub', 'D:\\BookRepository\\Pictures\\c1f85c53-48b9-405e-833e-3e16aad7f591西方哲学史.epub.jpg', 'http://book.douban.com/subject_search?search_text=西方哲学史.epub', '0');
INSERT INTO `book` VALUES ('c264655e-eb1b-45cc-bf99-053e71a8b2ae', 'a16749a3-fc05-48ee-96d4-52c1fc0243ac', '社会心理学.pdf', 'D:\\BookRepository\\BookStore\\心理学\\社会心理学.pdf', 'D:\\BookRepository\\Pictures\\c264655e-eb1b-45cc-bf99-053e71a8b2ae社会心理学.pdf.jpg', 'http://book.douban.com/subject_search?search_text=社会心理学.pdf', '0');
INSERT INTO `book` VALUES ('c26ab048-e103-44d6-a3c9-ef31f1b09ecf', '03f7f27d-1960-4e08-a9cd-32aba38f8823', '结网完整版.pdf', 'D:\\BookRepository\\BookStore\\IT\\结网完整版.pdf', 'D:\\BookRepository\\Pictures\\c26ab048-e103-44d6-a3c9-ef31f1b09ecf结网完整版.pdf.jpg', 'http://book.douban.com/subject_search?search_text=结网完整版.pdf', '0');
INSERT INTO `book` VALUES ('c29e000c-50c5-4219-998d-0d27532f8f15', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '理想国.epub', 'D:\\BookRepository\\BookStore\\社科\\理想国.epub', 'D:\\BookRepository\\Pictures\\c29e000c-50c5-4219-998d-0d27532f8f15理想国.epub.jpg', 'http://book.douban.com/subject_search?search_text=理想国.epub', '0');
INSERT INTO `book` VALUES ('c4e69f30-f02b-471f-bc6c-7f2c151f9d14', '03f7f27d-1960-4e08-a9cd-32aba38f8823', 'C#高级编程(第7版).pdf', 'D:\\BookRepository\\BookStore\\IT\\C#高级编程(第7版).pdf', 'D:\\BookRepository\\Pictures\\c4e69f30-f02b-471f-bc6c-7f2c151f9d14C#高级编程(第7版).pdf.jpg', 'http://book.douban.com/subject_search?search_text=C#高级编程(第7版).pdf', '0');
INSERT INTO `book` VALUES ('c7f38b3e-2049-4f1e-9cc6-1a516fef67b7', '5bc5de06-c349-4077-8766-d6a0d2ff3cb9', '高效能人士的七个习惯.mobi', 'D:\\BookRepository\\BookStore\\时间管理\\高效能人士的七个习惯.mobi', 'D:\\BookRepository\\Pictures\\c7f38b3e-2049-4f1e-9cc6-1a516fef67b7高效能人士的七个习惯.mobi.jpg', 'http://book.douban.com/subject_search?search_text=高效能人士的七个习惯.mobi', '0');
INSERT INTO `book` VALUES ('c8cae95e-a8fc-4477-a90d-d7bf18630184', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '文明的冲突与世界秩序的重建.epub', 'D:\\BookRepository\\BookStore\\社科\\文明的冲突与世界秩序的重建.epub', 'D:\\BookRepository\\Pictures\\c8cae95e-a8fc-4477-a90d-d7bf18630184文明的冲突与世界秩序的重建.epub.jpg', 'http://book.douban.com/subject_search?search_text=文明的冲突与世界秩序的重建.epub', '0');
INSERT INTO `book` VALUES ('c9cfef70-7dfb-4745-8670-04576e031fed', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '中国思想通俗讲话.mobi', 'D:\\BookRepository\\BookStore\\社科\\中国思想通俗讲话.mobi', 'D:\\BookRepository\\Pictures\\c9cfef70-7dfb-4745-8670-04576e031fed中国思想通俗讲话.mobi.jpg', 'http://book.douban.com/subject_search?search_text=中国思想通俗讲话.mobi', '0');
INSERT INTO `book` VALUES ('c9dbb1fc-4302-4a47-9c14-dcc321be08db', 'ef672de5-ac8f-4106-a3ac-28a4c6799687', '万物简史.epub', 'D:\\BookRepository\\BookStore\\自然科学\\万物简史.epub', 'D:\\BookRepository\\Pictures\\c9dbb1fc-4302-4a47-9c14-dcc321be08db万物简史.epub.jpg', 'http://book.douban.com/subject_search?search_text=万物简史.epub', '0');
INSERT INTO `book` VALUES ('ca455fd9-3e96-428f-834a-beec1342cbdb', '03f7f27d-1960-4e08-a9cd-32aba38f8823', '暗时间.mobi', 'D:\\BookRepository\\BookStore\\IT\\暗时间.mobi', 'D:\\BookRepository\\Pictures\\ca455fd9-3e96-428f-834a-beec1342cbdb暗时间.mobi.jpg', 'http://book.douban.com/subject_search?search_text=暗时间.mobi', '0');
INSERT INTO `book` VALUES ('cf3d6a5b-f8e0-4c63-a7e4-f2d6915ffebc', '03f7f27d-1960-4e08-a9cd-32aba38f8823', '走出软件作坊.pdf', 'D:\\BookRepository\\BookStore\\IT\\走出软件作坊.pdf', 'D:\\BookRepository\\Pictures\\cf3d6a5b-f8e0-4c63-a7e4-f2d6915ffebc走出软件作坊.pdf.jpg', 'http://book.douban.com/subject_search?search_text=走出软件作坊.pdf', '0');
INSERT INTO `book` VALUES ('d1061215-493a-4b6c-8d68-4a0a0babb771', '6524c87a-ef83-4adc-b652-32348692d696', '不二.mobi', 'D:\\BookRepository\\BookStore\\文学\\小说\\不二.mobi', 'D:\\BookRepository\\Pictures\\d1061215-493a-4b6c-8d68-4a0a0babb771不二.mobi.jpg', 'http://book.douban.com/subject_search?search_text=不二.mobi', '0');
INSERT INTO `book` VALUES ('d25456d6-45a2-4f77-bdfd-aa4b9487d1dc', '001f13cd-0bbc-4691-8e0b-69cccce27982', '箭术与禅心.pdf', 'D:\\BookRepository\\BookStore\\修炼\\箭术与禅心.pdf', 'D:\\BookRepository\\Pictures\\d25456d6-45a2-4f77-bdfd-aa4b9487d1dc箭术与禅心.pdf.jpg', 'http://book.douban.com/subject_search?search_text=箭术与禅心.pdf', '0');
INSERT INTO `book` VALUES ('d37046fd-e7fe-45a6-b450-905c11fdbad0', 'b9980d8f-36e6-4740-8d97-0d6c81674cce', '我的奋斗.epub', 'D:\\BookRepository\\BookStore\\文学\\纪实\\我的奋斗.epub', 'D:\\BookRepository\\Pictures\\d37046fd-e7fe-45a6-b450-905c11fdbad0我的奋斗.epub.jpg', 'http://book.douban.com/subject_search?search_text=我的奋斗.epub', '0');
INSERT INTO `book` VALUES ('d927ee40-707e-42e1-8f62-55095bbdd4fe', 'dfa03605-ce58-435f-956f-9150f8303d90', '维根特斯坦《逻辑哲学论》中英对照.pdf', 'D:\\BookRepository\\BookStore\\哲学\\维根特斯坦《逻辑哲学论》中英对照.pdf', 'D:\\BookRepository\\Pictures\\d927ee40-707e-42e1-8f62-55095bbdd4fe维根特斯坦《逻辑哲学论》中英对照.pdf.jpg', 'http://book.douban.com/subject_search?search_text=维根特斯坦《逻辑哲学论》中英对照.pdf', '0');
INSERT INTO `book` VALUES ('dcad2ee3-408f-43c6-a0b2-7acd8e564033', '6524c87a-ef83-4adc-b652-32348692d696', '顾异.pdf', 'D:\\BookRepository\\BookStore\\文学\\小说\\顾异.pdf', 'D:\\BookRepository\\Pictures\\dcad2ee3-408f-43c6-a0b2-7acd8e564033顾异.pdf.jpg', 'http://book.douban.com/subject_search?search_text=顾异.pdf', '0');
INSERT INTO `book` VALUES ('dfea6520-b98e-4bd4-9ddb-582671a0232c', '9f4411f1-ba98-4197-a444-dcd97f129028', '呐喊.epub', 'D:\\BookRepository\\BookStore\\文学\\杂文\\呐喊.epub', 'D:\\BookRepository\\Pictures\\dfea6520-b98e-4bd4-9ddb-582671a0232c呐喊.epub.jpg', 'http://book.douban.com/subject_search?search_text=呐喊.epub', '0');
INSERT INTO `book` VALUES ('e0e4cf9d-a004-4f42-8089-24b5bf7fa24a', '7d8e46e6-11c2-4002-af08-cff21fb0fc63', 'Head+First+设计模式.pdf', 'D:\\BookRepository\\BookStore\\CS\\Head+First+设计模式.pdf', 'D:\\BookRepository\\Pictures\\e0e4cf9d-a004-4f42-8089-24b5bf7fa24aHead+First+设计模式.pdf.jpg', 'http://book.douban.com/subject_search?search_text=Head+First+设计模式.pdf', '0');
INSERT INTO `book` VALUES ('e5b233aa-09ad-4b12-a0a4-b2712a37d950', 'be13cd45-fd37-4a96-b855-d99f3416c732', '无价--洞悉大众心理玩转价格游戏.pdf', 'D:\\BookRepository\\BookStore\\经管\\无价--洞悉大众心理玩转价格游戏.pdf', 'D:\\BookRepository\\Pictures\\e5b233aa-09ad-4b12-a0a4-b2712a37d950无价--洞悉大众心理玩转价格游戏.pdf.jpg', 'http://book.douban.com/subject_search?search_text=无价--洞悉大众心理玩转价格游戏.pdf', '0');
INSERT INTO `book` VALUES ('e98a3ce8-ab87-46be-ad57-d1b0211df2c0', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '朱镕基答记者问.epub', 'D:\\BookRepository\\BookStore\\社科\\朱镕基答记者问.epub', 'D:\\BookRepository\\Pictures\\e98a3ce8-ab87-46be-ad57-d1b0211df2c0朱镕基答记者问.epub.jpg', 'http://book.douban.com/subject_search?search_text=朱镕基答记者问.epub', '0');
INSERT INTO `book` VALUES ('e9d69ed4-bec8-4128-8500-e17771d665c5', '6524c87a-ef83-4adc-b652-32348692d696', '金庸全集.epub', 'D:\\BookRepository\\BookStore\\文学\\小说\\金庸全集.epub', 'D:\\BookRepository\\Pictures\\e9d69ed4-bec8-4128-8500-e17771d665c5金庸全集.epub.jpg', 'http://book.douban.com/subject_search?search_text=金庸全集.epub', '0');
INSERT INTO `book` VALUES ('eb00764f-8ab0-44cc-a63f-bcd4f3c2318f', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '开放社会及其敌人karl.pdf', 'D:\\BookRepository\\BookStore\\社科\\开放社会及其敌人karl.pdf', 'D:\\BookRepository\\Pictures\\eb00764f-8ab0-44cc-a63f-bcd4f3c2318f开放社会及其敌人karl.pdf.jpg', 'http://book.douban.com/subject_search?search_text=开放社会及其敌人karl.pdf', '0');
INSERT INTO `book` VALUES ('edd94a78-4b93-4d5b-92d1-94e9efb91f78', '6524c87a-ef83-4adc-b652-32348692d696', '冯唐作品集.epub', 'D:\\BookRepository\\BookStore\\文学\\小说\\冯唐作品集.epub', 'D:\\BookRepository\\Pictures\\edd94a78-4b93-4d5b-92d1-94e9efb91f78冯唐作品集.epub.jpg', 'http://book.douban.com/subject_search?search_text=冯唐作品集.epub', '0');
INSERT INTO `book` VALUES ('f15ae42d-dad2-466c-b3bc-52b505078cf1', '2aaa037e-72f9-4be5-90fe-7346f554c380', '剑桥中国史（全集）.epub', 'D:\\BookRepository\\BookStore\\历史\\剑桥中国史（全集）.epub', 'D:\\BookRepository\\Pictures\\f15ae42d-dad2-466c-b3bc-52b505078cf1剑桥中国史（全集）.epub.jpg', 'http://book.douban.com/subject_search?search_text=剑桥中国史（全集）.epub', '0');
INSERT INTO `book` VALUES ('f1fc0a87-3dd5-44ea-b95b-be7cbfc15b5e', 'a16749a3-fc05-48ee-96d4-52c1fc0243ac', '乌合之众—大众心理研究.epub', 'D:\\BookRepository\\BookStore\\心理学\\乌合之众—大众心理研究.epub', 'D:\\BookRepository\\Pictures\\f1fc0a87-3dd5-44ea-b95b-be7cbfc15b5e乌合之众—大众心理研究.epub.jpg', 'http://book.douban.com/subject_search?search_text=乌合之众—大众心理研究.epub', '1');
INSERT INTO `book` VALUES ('f38da164-ec8b-4019-9c9a-7337aaa49374', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '社会契约论.epub', 'D:\\BookRepository\\BookStore\\社科\\社会契约论.epub', 'D:\\BookRepository\\Pictures\\f38da164-ec8b-4019-9c9a-7337aaa49374社会契约论.epub.jpg', 'http://book.douban.com/subject_search?search_text=社会契约论.epub', '0');
INSERT INTO `book` VALUES ('fb45cc0a-c950-48da-aaec-6ecc9ebcf895', '1117d65e-a351-46ea-8197-a2d2e6df4161', '让数据站住脚.pdf', 'D:\\BookRepository\\BookStore\\方法论\\让数据站住脚.pdf', 'D:\\BookRepository\\Pictures\\fb45cc0a-c950-48da-aaec-6ecc9ebcf895让数据站住脚.pdf.jpg', 'http://book.douban.com/subject_search?search_text=让数据站住脚.pdf', '0');
INSERT INTO `book` VALUES ('fc605c7e-eb71-4fc8-993a-08bd3d180264', 'be13cd45-fd37-4a96-b855-d99f3416c732', '经济学原理（插图版）.epub', 'D:\\BookRepository\\BookStore\\经管\\经济学原理（插图版）.epub', 'D:\\BookRepository\\Pictures\\fc605c7e-eb71-4fc8-993a-08bd3d180264经济学原理（插图版）.epub.jpg', 'http://book.douban.com/subject_search?search_text=经济学原理（插图版）.epub', '0');
INSERT INTO `book` VALUES ('fe16f857-3485-45b5-a399-8466dec5de2c', '9e3519e6-48dc-4f86-88b6-c6cb78f091de', '极权主义的起源.mobi', 'D:\\BookRepository\\BookStore\\社科\\极权主义的起源.mobi', 'D:\\BookRepository\\Pictures\\fe16f857-3485-45b5-a399-8466dec5de2c极权主义的起源.mobi.jpg', 'http://book.douban.com/subject_search?search_text=极权主义的起源.mobi', '0');
INSERT INTO `book` VALUES ('ff0a98a9-632d-4da4-a3eb-f45a69e7e017', 'ef672de5-ac8f-4106-a3ac-28a4c6799687', '时间简史.epub', 'D:\\BookRepository\\BookStore\\自然科学\\时间简史.epub', 'D:\\BookRepository\\Pictures\\ff0a98a9-632d-4da4-a3eb-f45a69e7e017时间简史.epub.jpg', 'http://book.douban.com/subject_search?search_text=时间简史.epub', '0');

-- ----------------------------
-- Table structure for `bookcatalog`
-- ----------------------------
DROP TABLE IF EXISTS `bookcatalog`;
CREATE TABLE `bookcatalog` (
  `bookid` varchar(50) NOT NULL,
  `catalog` varchar(3000) default NULL,
  PRIMARY KEY  (`bookid`),
  KEY `idx_catalog_bookid` USING BTREE (`bookid`),
  CONSTRAINT `fk_catalog_bookid` FOREIGN KEY (`bookid`) REFERENCES `book` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of bookcatalog
-- ----------------------------

-- ----------------------------
-- Table structure for `bookdetail`
-- ----------------------------
DROP TABLE IF EXISTS `bookdetail`;
CREATE TABLE `bookdetail` (
  `bookid` varchar(50) NOT NULL,
  `author` varchar(20) default NULL,
  `translator` varchar(20) default NULL,
  `sort` varchar(20) default NULL,
  `words` varchar(20) default NULL,
  `publisher` varchar(80) default NULL,
  `publishdate` date default NULL,
  `ISBN` varchar(20) default NULL,
  `provider` varchar(20) default NULL,
  `label` varchar(20) default NULL,
  PRIMARY KEY  (`bookid`),
  KEY `idx_detail_bookid` (`bookid`),
  CONSTRAINT `fk_detail_bookid` FOREIGN KEY (`bookid`) REFERENCES `book` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of bookdetail
-- ----------------------------

-- ----------------------------
-- Table structure for `bookintroduction`
-- ----------------------------
DROP TABLE IF EXISTS `bookintroduction`;
CREATE TABLE `bookintroduction` (
  `bookid` varchar(50) NOT NULL,
  `introduction` varchar(3000) default NULL,
  PRIMARY KEY  (`bookid`),
  KEY `idx_introdution_bookid` (`bookid`),
  CONSTRAINT `fk_introduction_bookid` FOREIGN KEY (`bookid`) REFERENCES `book` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of bookintroduction
-- ----------------------------

-- ----------------------------
-- Table structure for `category`
-- ----------------------------
DROP TABLE IF EXISTS `category`;
CREATE TABLE `category` (
  `id` varchar(50) NOT NULL,
  `parentid` varchar(50) default NULL,
  `categoryname` varchar(100) NOT NULL,
  PRIMARY KEY  (`id`),
  KEY `idx_id` (`id`),
  KEY `idx_categoryname` (`categoryname`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of category
-- ----------------------------
INSERT INTO `category` VALUES ('001f13cd-0bbc-4691-8e0b-69cccce27982', 'c9de4357-f659-4755-9c8d-4648ee87a90b', '修炼');
INSERT INTO `category` VALUES ('03f7f27d-1960-4e08-a9cd-32aba38f8823', 'c9de4357-f659-4755-9c8d-4648ee87a90b', 'IT');
INSERT INTO `category` VALUES ('1117d65e-a351-46ea-8197-a2d2e6df4161', 'c9de4357-f659-4755-9c8d-4648ee87a90b', '方法论');
INSERT INTO `category` VALUES ('2368052a-dd0a-4f77-b486-3293acec006b', 'c9de4357-f659-4755-9c8d-4648ee87a90b', '未分类');
INSERT INTO `category` VALUES ('2aaa037e-72f9-4be5-90fe-7346f554c380', 'c9de4357-f659-4755-9c8d-4648ee87a90b', '历史');
INSERT INTO `category` VALUES ('5bc5de06-c349-4077-8766-d6a0d2ff3cb9', 'c9de4357-f659-4755-9c8d-4648ee87a90b', '时间管理');
INSERT INTO `category` VALUES ('6524c87a-ef83-4adc-b652-32348692d696', '78769aeb-c098-4a34-b453-ef869e43d2d6', '文学\\小说');
INSERT INTO `category` VALUES ('78769aeb-c098-4a34-b453-ef869e43d2d6', 'c9de4357-f659-4755-9c8d-4648ee87a90b', '文学');
INSERT INTO `category` VALUES ('7d8e46e6-11c2-4002-af08-cff21fb0fc63', 'c9de4357-f659-4755-9c8d-4648ee87a90b', 'CS');
INSERT INTO `category` VALUES ('9e3519e6-48dc-4f86-88b6-c6cb78f091de', 'c9de4357-f659-4755-9c8d-4648ee87a90b', '社科');
INSERT INTO `category` VALUES ('9f4411f1-ba98-4197-a444-dcd97f129028', '78769aeb-c098-4a34-b453-ef869e43d2d6', '文学\\杂文');
INSERT INTO `category` VALUES ('a16749a3-fc05-48ee-96d4-52c1fc0243ac', 'c9de4357-f659-4755-9c8d-4648ee87a90b', '心理学');
INSERT INTO `category` VALUES ('b9980d8f-36e6-4740-8d97-0d6c81674cce', '78769aeb-c098-4a34-b453-ef869e43d2d6', '文学\\纪实');
INSERT INTO `category` VALUES ('be13cd45-fd37-4a96-b855-d99f3416c732', 'c9de4357-f659-4755-9c8d-4648ee87a90b', '经管');
INSERT INTO `category` VALUES ('c9de4357-f659-4755-9c8d-4648ee87a90b', '', 'BookStore');
INSERT INTO `category` VALUES ('dfa03605-ce58-435f-956f-9150f8303d90', 'c9de4357-f659-4755-9c8d-4648ee87a90b', '哲学');
INSERT INTO `category` VALUES ('ef672de5-ac8f-4106-a3ac-28a4c6799687', 'c9de4357-f659-4755-9c8d-4648ee87a90b', '自然科学');

-- ----------------------------
-- Table structure for `settings`
-- ----------------------------
DROP TABLE IF EXISTS `settings`;
CREATE TABLE `settings` (
  `settingkey` varchar(50) NOT NULL,
  `settingvalue` varchar(50) default NULL,
  PRIMARY KEY  (`settingkey`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of settings
-- ----------------------------
