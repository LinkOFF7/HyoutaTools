﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyoutaTools.Tales.Vesperia.Website {
	public partial class WebsiteGenerator {
		private static readonly string ScenarioCss = @"
div.scenario-content {
    overflow: hidden;
}
div.scenario-previous-next {
}
div.storyBox {
    margin-top: 10px;
}

.storyBlock {
    display: inline-block;
    vertical-align: top;
    width: 480px;
    padding-right: 20px;
    text-align: center;
}

.skitBlock {
    display: inline-block;
    vertical-align: top;
    width: 450px;
    text-align: left;
}

.storyText {
    /* font-family: ""Baskerville"",serif; */
    position: relative;
    padding-bottom: 20px;
    color: #2f1f1b;
}

.storyTitleEN {
    text-align: center;
    color: #FCD18E;
    font-size: 18px;
    text-shadow: 0px 0px 2px #E48C36;
    padding-bottom: 20px;
}

.storyTitleJP {
    text-align: center;
    color: #FCD18E;
    font-size: 18px;
    text-shadow: 0px 0px 2px #E48C36;
}

.charaContainer {
    background-color: #184354;
    border-radius: 12px;
    display: inline-block;
    margin-left: 10px;
}

.storyText .charaContainer {
    position: absolute;
}

.charaSubContainer {
    background-color: #27576b;
    border-radius: 12px;
    margin-left: 5px;
    margin-right: 5px;
    display: inline-block;
}

.charaSubSubContainer {
    font-size: 17px;
    line-height: 25px;
    vertical-align: middle;
    background-color: #386b86;
    color: #adcad8;
    border-radius: 12px;
    margin-left: 5px;
    padding-left: 12px;
    padding-right: 12px;
    margin-right: 5px;
    display: inline-block;
}

.textContainerSub {
    background-color: #FFFAE7;
    border: 2px solid #8D7F76;
    border-radius: 60px;
    padding: 7px 40px;
    font-size: 17px;
    margin-top: 20px;
    display: inline-block;
    -moz-box-shadow: 4px 4px 15px rgba(0, 0, 0, .6);
    -webkit-box-shadow: 4px 4px 15px rgba(0, 0, 0, .6);
    box-shadow: 4px 4px 15px rgba(0, 0, 0, .6);
    min-width: 50px;
}

/* info boxes */
.storyText1 {
	position: relative;
	color: #2f1f1b;
	background-color: #F1B36D;
	/* border: 2px solid #BD8042; */
	-moz-box-shadow: 4px 4px 15px rgba(0, 0, 0, .6);
	-webkit-box-shadow: 4px 4px 15px rgba(0, 0, 0, .6);
	box-shadow: 4px 4px 15px rgba(0, 0, 0, .6);
	margin-bottom: 20px;
}
.storyTextSub1 {
	padding: 6px;
	border: 5px solid #5A3929;
	background-color: #BD8042
}
.textContainerSub1 {
	padding-top: 2px;
	padding-bottom: 3px;
	padding-left: 4px;
	padding-right: 4px;
	font-size: 17px;
	min-width: 150px;
	background-color: #F1B36D;
}
.charaContainer1 {
	background-color: #BD8042;
	padding-bottom: 6px;
}
.charaSubContainer1 {
	background-color: #9E6931;
	border-radius: 12px;
	margin-left: 5px;
	margin-right: 5px;
}
.charaSubSubContainer1 {
	font-size: 17px;
	line-height: 25px;
	vertical-align: middle;
	background-color: #9E6931;
	border-radius: 12px;
	color: #F1B36D;
	margin-left: 5px;
	padding-left: 12px;
	padding-right: 12px;
	margin-right: 5px;
	display: inline-block;
}

/* fmv subtitles */
.textContainerSub2 {
    background-color: #2f1f1b;
    border-radius: 60px;
    padding: 7px 40px;
    font-size: 17px;
    margin-top: 20px;
    -moz-box-shadow: 4px 4px 15px rgba(0, 0, 0, .6);
    -webkit-box-shadow: 4px 4px 15px rgba(0, 0, 0, .6);
    box-shadow: 4px 4px 15px rgba(0, 0, 0, .6);
    min-width: 150px;
}
.storyText2 {
    position: relative;
    padding-bottom: 20px;
    color: #FFFAE7;
}

.skitIcon {
    display: inline-block;
    padding-bottom: 20px;
    width: 48px;
}

div.skit-name {
    display: inline-block;
    text-align: center;
    width: 532px;
    font-weight: bold;
}

div.skitIconAndText {
    display: inline-block;
}

.textContainerSubSkit {
    border-radius: 6px;
    background-color: #2f1f1b;
    padding: 6px 20px;
    margin-left: 6px;
    margin-top: 20px;
    display: inline-block;
    -moz-box-shadow: 4px 4px 15px rgba(0, 0, 0, .6);
    -webkit-box-shadow: 4px 4px 15px rgba(0, 0, 0, .6);
    box-shadow: 4px 4px 15px rgba(0, 0, 0, .6);
}

.skitText {
    position: relative;
    padding-bottom: 20px;
    color: #FFFAE7;
}

.charaContainerSkit {
    border-radius: 12px;
    background-color: #2f1f1b;
    display: inline-block;
}

.skitText .charaContainerSkit {
    position: absolute;
}

.charaSubContainerSkit {
    border-radius: 12px;
    background-color: #2f1f1b;
    margin-left: 5px;
    margin-right: 5px;
    display: inline-block;
}

.charaSubSubContainerSkit {
    border-radius: 12px;
    font-size: 17px;
    line-height: 25px;
    vertical-align: middle;
    background-color: #2f1f1b;
    color: #FFFAE7;
    margin-left: 5px;
    padding-left: 4px;
    padding-right: 4px;
    margin-right: 5px;
    display: inline-block;
}

.textJP {
    /* font-family: ""Kozuka Gothic Pr6N""; */
    font-size: 16px;
}

.textEN  {
    font-size: 17px;
}

ul {
    list-style-type: none;
    padding: 0px;
    margin: 0px;
}

ul li {
    padding-left: 15px;
}
ul li ul li ul li {
    background-image: url(text-icons/PS3/button-Select.png);
    background-size: 23px 16px;
    padding-left: 25px;
    background-repeat: no-repeat;
    background-position: 1px 2px;
}

span.textColorBlue { color: #558BEA; }
span.textColorGreen { color: #05AA51; }
span.textColorRed { color: #F5332F; }
span.textColorWhite { color: #FFFAE7; }
div.storyText span.textColorWhite { color: #AAAAAA; }
";
	}
}
