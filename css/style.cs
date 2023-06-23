@import url("https://fonts.googleapis.com/css?family=Open+Sans:wght@400&family=Public+Sans@500;900&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Ubuntu:wght@300;400;500&display=swap");
@import url("https://fonts.cdnfonts.com/css/verdana");
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  color: #080808;
}

h1,
h2,
h3,
h4 {
  padding: 0;
  margin: 0;
  font-weight: 400;
}

ul,
ol,
li {
  list-style: none;
}

a {
  text-decoration: none;
}

button {
  border: 0;
  background: transparent;
  cursor: pointer;
}

body {
  background: #f0f0f0;
  min-width: 320px;
  font-size: 16px;
  font-family: "arial", sans-serif;
  word-break: break-word;
}

fieldset {
  border: none;
}

table {
  border-collapse: collapse;
}

input,
label {
  vertical-align: middle;
}

.text_hidden {
  position: absolute;
  display: inline-block;
  width: 0;
  height: 0;
  margin: -1px;
  overflow: hidden;
  clip: rect(0, 0, 0, 0);
}

.head_title, .head_title * {
  font-size: 10vw;
  font-weight: bold;
  font-family: "Bebas Neue", sans-serif;
  line-height: 0.8;
  letter-spacing: -2px;
}
.head_title__sub {
  font-size: 10px;
  line-height: 1.2;
  vertical-align: middle;
}

.logo a {
  font: bold 26px/1 "sans-serif";
  letter-spacing: -1px;
}

.gnb {
  margin-left: 100px;
}
.gnb::after {
  display: block;
  clear: both;
  content: "";
}
.gnb li {
  float: left;
}
.gnb li:not(:first-child) {
  margin-left: 20px;
}
.gnb li a {
  position: relative;
  display: inline-block;
  color: #080808;
  font-weight: 500;
  font-size: 20px;
  font-family: "Verdana", sans-serif;
  line-height: 33px;
}
.gnb li a::before {
  content: "";
  position: absolute;
  width: 100%;
  height: 1px;
  background-color: #080808;
  bottom: 0;
  left: 0;
  transform-origin: right;
  transform: scaleX(0);
  transition: transform 0.3s ease-in-out;
}
.gnb li a:hover::before {
  transform-origin: left;
  transform: scaleX(1);
}

.btn_round {
  overflow: hidden;
  position: relative;
  display: inline-flex;
  align-items: center;
  justify-content: center;
  width: auto;
  height: 33px;
  margin-right: 8px;
  background: transparent;
  padding: 0 25px 0 22px;
  border-radius: 33px;
  border: 1px solid #080808;
  transition: border-color 1s ease-out;
}
.btn_round span {
  position: relative;
  display: inline-block;
  width: auto;
  height: auto;
  font: 500 18px/1 "Verdana", sans-serif;
  z-index: 2;
}
.btn_round span:after {
  position: absolute;
  top: 0;
  right: 8px;
  display: inline-block;
  width: 33px;
  height: 33px;
  background: #ff3c31;
  border-radius: 100%;
  font-size: 18px;
}
.btn_round::before {
  position: absolute;
  top: 0;
  right: 0;
  overflow: hidden;
  display: inline-block;
  width: 100%;
  height: 100%;
  transform: scaleY(0);
  transform-origin: left bottom;
  transition: 0.3s ease-in-out;
  content: "";
  z-index: 1;
}
.btn_round:hover {
  border-color: #ff3c31;
}
.btn_round:hover::before {
  background: #ff3c31;
  transform: scaleY(1);
}

.text_tab {
  margin-left: 17vw;
}

#scroll_navi {
  position: fixed;
  top: 50%;
  right: 3%;
  transform: translateY(-50%);
  width: 26px;
  height: auto;
  display: flex;
  flex-direction: column;
}
#scroll_navi::before {
  position: absolute;
  top: 0;
  left: 50%;
  transform: translateX(-50%);
  display: block;
  background: #000;
  width: 2px;
  height: 100%;
  border-radius: 2px;
  content: "";
  z-index: 1;
}
#scroll_navi button {
  position: relative;
  width: 26px;
  height: 26px;
  border-radius: 26px;
  background: #f0f0f0;
  border: 1px solid #080808;
  z-index: 2;
  transition: background-color 0.2s;
  cursor: pointer;
}
#scroll_navi button:not(:first-child) {
  margin-top: 26px;
}
#scroll_navi .tab_active__bg {
  display: block;
  position: absolute;
  top: 0;
  left: -2px;
  background: #f0f0f0 url("../../img/circle-solid.svg") no-repeat center;
  background-size: contain;
  width: 30px;
  height: 30px;
  z-index: 3;
  opacity: 0;
  transform: translateY(-2px);
  transition: all 0.2s ease-in-out;
  border-radius: 30px;
}
#scroll_navi button.on ~ .tab_active__bg {
  transition: all 0.2s ease-in-out;
  opacity: 1;
}
#scroll_navi button.on:nth-child(1) ~ .tab_active__bg {
  transform: translateY(-2px);
}
#scroll_navi button.on:nth-child(2) ~ .tab_active__bg {
  transform: translateY(50px);
}
#scroll_navi button.on:nth-child(3) ~ .tab_active__bg {
  transform: translateY(102px);
}
#scroll_navi button.on:nth-child(4) ~ .tab_active__bg {
  transform: translateY(154px);
}
#scroll_navi button.on:nth-child(5) ~ .tab_active__bg {
  transform: translateY(206px);
}

.main_wrap,
.sub_wrap {
  height: auto;
  min-height: 625px;
  padding-top: 160px;
}

.sub_wrap {
  padding-bottom: 120px;
  color: #333;
  position: relative;
}
.sub_wrap::after {
  display: block;
  width: 100%;
  height: 30px;
  border-radius: 0 0 30px 30px;
  background: #f0f0f0;
  content: "";
  position: absolute;
  bottom: -30px;
  left: 0;
}

@media screen and (max-width: 979px) {
  .head_title, .head_title * {
    font-size: 15vw;
  }
}
@media screen and (max-width: 639px) {
  .head_title, .head_title * {
    font-size: 13vw;
  }
}
.header_wrap {
  position: fixed;
  top: 0;
  left: 0;
  z-index: 10;
  background: #f0f0f0;
  display: flex;
  align-items: center;
  width: 100%;
  padding: 10px 5%;
  opacity: 1;
  transition: transform 0.3s ease;
}
.header_wrap.scrollDown {
  transform: translate3d(0, -100px, 0);
}
.header_wrap #nav {
  flex: 1;
  height: 33px;
}
.header_wrap .nav_side_btn {
  position: relative;
  display: inline-block;
  width: auto;
  height: 33px;
  font: 500 18px/33px Verdana, Tahoma, sans-serif;
  padding: 0 30px;
  transition: all 0.3s ease-in-out;
}
.header_wrap .nav_side_btn::before {
  position: absolute;
  top: 0;
  right: 0;
  display: inline-block;
  width: 100%;
  height: 100%;
  border: 1px solid #080808;
  border-radius: 33px;
  box-sizing: border-box;
  content: "";
  transition: 0.5s ease-in-out;
}
.header_wrap .nav_side_btn:hover {
  padding-right: 40px;
}
.header_wrap .nav_side_btn:hover::before {
  width: 33px;
  background: #ff3c31;
  border: 0;
}
.header_wrap .btn_menu {
  display: none;
  margin-left: 20px;
  width: 33px;
  padding: 0 6px;
  height: 33px;
  line-height: 33px;
  text-align: center;
}
.header_wrap .btn_menu i {
  font-size: 20px;
}

@media screen and (max-width: 979px) {
  .header_wrap {
    justify-content: space-between;
  }
  .header_wrap #nav {
    display: none;
  }
  .header_wrap .nav_side {
    flex: 1;
    text-align: right;
  }
  .header_wrap .btn_menu {
    display: inline-block;
  }
}
@media screen and (max-width: 639px) {
  .header_wrap .nav_side_btn {
    padding: 0 10px;
  }
}
.footer_wrap {
  padding: 3% 5%;
  padding-top: 100px;
  background: rgba(0, 0, 0, 0.9);
  color: #d5d5d5;
}
.footer_wrap * {
  color: #d5d5d5;
}
.footer_wrap .footer_top {
  display: flex;
}
.footer_wrap .footer_top .btn_totop {
  display: inline-block;
  width: auto;
  height: 30px;
  color: #d5d5d5;
  position: relative;
  padding-bottom: 2px;
  font-size: 20px;
  font-family: "Verdana", sans-serif;
}
.footer_wrap .footer_top .btn_totop::before {
  content: "";
  position: absolute;
  width: 100%;
  height: 1px;
  background-color: #d5d5d5;
  bottom: 0;
  left: 0;
  transform-origin: right;
  transform: scaleX(0);
  transition: transform 0.3s ease-in-out;
}
.footer_wrap .footer_top .btn_totop:hover::before {
  transform-origin: left;
  transform: scaleX(1);
}
.footer_wrap .footer_top__clock {
  width: 220px;
}
.footer_wrap .footer_top__clock .country {
  font-size: 20px;
  font-weight: 500;
  letter-spacing: 1px;
  font-family: "Verdana", sans-serif;
}
.footer_wrap .footer_top__clock .clock_text {
  display: flex;
  margin-top: 10px;
  font-size: 20px;
  font-weight: 300;
  letter-spacing: 3px;
  font-family: "Verdana", sans-serif;
}
.footer_wrap .footer_top__clock .clock_text .clock_dot {
  animation: blink 1s step-end infinite;
}
@keyframes blink {
  50% {
    opacity: 0;
  }
}
.footer_wrap .footer_top__clock .clock_text .clock_dl {
  display: none;
  margin-left: 5px;
}
.footer_wrap .footer_top__clock .clock_text .clock_dl.on {
  display: block;
}
.footer_wrap .footer_top__content {
  flex: 1;
  padding-right: 200px;
}
.footer_wrap .footer_top__content .footer_sns {
  display: flex;
  align-items: center;
  width: 100%;
  margin-left: -5px;
}
.footer_wrap .footer_top__content .footer_sns li:not(:first-child) {
  margin-left: 10px;
}
.footer_wrap .footer_top__content .footer_sns li a {
  display: inline-block;
  width: 30px;
  height: 30px;
  text-align: center;
}
.footer_wrap .footer_top__content .footer_sns li a i {
  font-size: 20px;
}
.footer_wrap .footer_top__content .footer_desc {
  margin-top: 20px;
  padding-top: 15px;
  border-top: 1px solid #777;
}
.footer_wrap .footer_top__content .footer_desc * {
  color: #777;
}
.footer_wrap .footer_top__content .footer_desc p {
  margin-top: 5px;
  font-size: 14px;
}
.footer_wrap .footer_bottom {
  display: flex;
  align-items: center;
  width: 100%;
  margin-top: 100px;
}
.footer_wrap .footer_bottom .gnb {
  flex: 1;
}
.footer_wrap .footer_bottom .gnb li a {
  color: #fff;
}
.footer_wrap .footer_bottom .nav_side_btn {
  border: 2px solid white;
  height: 47px;
  margin: 0;
  line-height: 43px;
}
.footer_wrap .footer_bottom .nav_side_btn span {
  font-size: 30px;
}
.footer_wrap .footer_bottom .nav_side_btn:hover {
  border-color: #ff3c31;
}
.footer_wrap .footer_bottom .nav_side_btn:hover span {
  color: #080808;
}
.footer_wrap .footer_bottom .nav_side_btn:hover::before {
  background: #ff3c31;
  transform: scaleY(1);
}

@media screen and (max-width: 979px) {
  .footer_wrap {
    position: relative;
  }
  .footer_wrap .footer_top {
    display: block;
  }
  .footer_wrap .footer_top__content {
    padding-right: 0;
    margin-top: 40px;
    margin-bottom: 40px;
  }
  .footer_wrap .footer_top .btn_totop {
    position: absolute;
    top: 5%;
    right: 5%;
  }
  .footer_wrap .footer_bottom {
    justify-content: space-between;
  }
  .footer_wrap .footer_bottom .gnb {
    display: none;
  }
}
@media screen and (max-width: 639px) {
  .footer_wrap .footer_top__content {
    text-align: center;
  }
  .footer_wrap .footer_top__content .footer_sns {
    justify-content: center;
    margin-left: 0;
  }
  .footer_wrap .footer_bottom {
    justify-content: space-between;
  }
  .footer_wrap .footer_bottom .gnb {
    display: none;
  }
  .footer_wrap .footer_bottom .nav_side_btn {
    height: 36px;
    line-height: 32px;
    margin: 0;
  }
  .footer_wrap .footer_bottom .nav_side_btn span {
    font-size: 1rem;
  }
}
.pop {
  width: 100%;
  height: 100vh;
  background: rgba(0, 0, 0, 0.9);
  position: fixed;
  top: 0;
  left: 0px;
  padding: 100px;
  z-index: 15;
  transition: 0.3s;
  opacity: 0;
}
.pop.on {
  opacity: 1;
}
.pop .con {
  width: 100%;
  height: 100%;
}
.pop .con iframe,
.pop .con img,
.pop .con video {
  width: 100%;
  height: 100%;
  object-fit: cover;
  border: 0;
}
.pop .con img {
  object-fit: contain;
}
.pop .close {
  font: bold 14px/1 Verdana, Tahoma, sans-serif;
  color: #fff;
  position: absolute;
  top: 30px;
  right: 50px;
  cursor: pointer;
}

.main_wrap .intro_wrap {
  padding: 0 10vw;
}
.main_wrap .intro_wrap .intro_head_wrap {
  display: flex;
  align-items: flex-end;
  justify-content: space-between;
}
.main_wrap .intro_wrap .intro_head_wrap .head_title__sub {
  padding-bottom: 10px;
}
.main_wrap .intro_wrap .intro_head_wrap .head_title__sub:last-of-type {
  text-align: right;
}
.main_wrap .intro_wrap .intro_head_wrap .intro_head {
  flex: 1;
  text-align: center;
}
.main_wrap .intro_wrap .intro_head_wrap .intro_head__sub {
  margin-bottom: 5px;
  font-weight: 400;
  font-size: 15px;
  line-height: 20px;
}
.main_wrap .intro_wrap .intro_head_wrap .intro_head .head_title, .main_wrap .intro_wrap .intro_head_wrap .intro_head .head_title *, .head_title .main_wrap .intro_wrap .intro_head_wrap .intro_head * {
  overflow: hidden;
  width: 100%;
  position: relative;
  height: 160px;
  line-height: 160px;
  position: relative;
  width: 100%;
}
.main_wrap .intro_wrap .intro_head_wrap .intro_head .head_title > h2, .main_wrap .intro_wrap .intro_head_wrap .intro_head .head_title * > h2, .head_title .main_wrap .intro_wrap .intro_head_wrap .intro_head * > h2 {
  padding-top: 7px;
  overflow: visible;
  margin-top: 0;
  position: absolute;
  top: 0;
  animation: slide 5s 1s cubic-bezier(0.25, 0.46, 0.45, 0.94) infinite;
}
@keyframes slide {
  0% {
    top: 0;
  }
  33% {
    top: -160px;
  }
  66% {
    top: -320px;
  }
  99% {
    top: 0;
  }
}
.main_wrap .intro_wrap .intro_visual {
  margin-top: 20px;
}
.main_wrap .intro_wrap .intro_visual__img {
  position: relative;
  overflow: hidden;
  width: 100%;
  height: 0;
  z-index: 1;
  background-color: gray;
  border-radius: 0.25em;
  padding-top: 56.25%;
}
.main_wrap .intro_wrap .intro_visual__img img,
.main_wrap .intro_wrap .intro_visual__img video {
  width: 100%;
  height: 100%;
  max-width: none;
  object-fit: cover;
  position: absolute;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
}
.main_wrap .intro_wrap .intro_bottom {
  display: block;
  width: 480px;
  margin: 10vw auto 12vw;
  text-align: center;
}
.main_wrap .intro_wrap .intro_bottom p + p {
  margin-top: 20px;
  font-size: 14px;
  font-weight: normal;
  line-height: 1.3;
  letter-spacing: 0;
}
@media screen and (max-width: 979px) {
  .main_wrap .main_wrap {
    padding-top: 100px;
  }
}
@media screen and (max-width: 639px) {
  .main_wrap .intro_wrap .intro_bottom {
    width: 100%;
    padding: 0 12vw;
  }
  .main_wrap .intro_wrap .intro_bottom p {
    font-size: 13px;
  }
  .main_wrap .intro_wrap .intro_bottom p + p {
    font-size: 12px;
  }
}

.main_wrap .work_wrap {
  padding: 0 10vw;
}
.main_wrap .work_wrap .inner {
  padding-top: 70px;
  border-top: 3px solid #080808;
}
.main_wrap .work_wrap .head_title_wrap {
  display: flex;
  align-items: flex-end;
  justify-content: space-between;
}
.main_wrap .work_wrap .head_title_wrap .head_title, .main_wrap .work_wrap .head_title_wrap .head_title *, .head_title .main_wrap .work_wrap .head_title_wrap * {
  font-size: 10vw;
}
.main_wrap .work_wrap .head_title_wrap .head_title__sub {
  display: inline-block;
  width: 140px;
  margin-right: 60px;
  padding-bottom: 25px;
}
.main_wrap .work_wrap .work_list_wrap {
  margin-top: 10vw;
}
.main_wrap .work_wrap .work_list_wrap .work_list {
  display: flex;
}
.main_wrap .work_wrap .work_list_wrap .work_list li {
  flex: 1;
  width: 33.3333333333%;
  border-left: 1px solid #080808;
  padding: 0 30px;
}
.main_wrap .work_wrap .work_list_wrap .work_item {
  display: block;
  width: 100%;
  height: 100%;
}
.main_wrap .work_wrap .work_list_wrap .work_item__num {
  margin-right: 5px;
  font-size: 10px;
  font-weight: 400;
  line-height: 1.2;
  text-transform: uppercase;
}
.main_wrap .work_wrap .work_list_wrap .work_item__desc {
  margin-top: 30px;
  font-size: 19px;
  font-weight: 400;
  line-height: 1.22;
}
.main_wrap .work_wrap .work_list_wrap .work_item__title {
  width: auto;
  display: inline-flex;
  align-items: center;
  margin-top: 4px;
  font-size: 19px;
  font-weight: bold;
  line-height: 1.22;
}
.main_wrap .work_wrap .work_list_wrap .work_item__title i {
  font-size: 11px;
  margin-right: 6px;
}
.main_wrap .work_wrap .work_list_wrap .work_item:hover .work_item__title > span {
  text-decoration: underline;
}
.main_wrap .work_wrap .work_list_wrap .work_item__img {
  position: relative;
  overflow: hidden;
  width: 100%;
  height: 530px;
  margin-top: 48px;
  background-color: #d8d8d8;
  border-radius: 1.25em;
}
.main_wrap .work_wrap .work_list_wrap .work_item__img img {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  object-fit: cover;
  transition: 0.5s cubic-bezier(0.25, 0.46, 0.45, 0.94);
}
.main_wrap .work_wrap .work_list_wrap .work_item__img img + img {
  left: 100%;
}
.main_wrap .work_wrap .work_list_wrap .work_item__img:hover img + img {
  left: 0;
}
.main_wrap .work_wrap .btn_wrap {
  margin-top: 64px;
  text-align: center;
}
@media screen and (max-width: 979px) {
  .main_wrap .work_wrap .head_title_wrap {
    justify-content: start;
    gap: 15px;
  }
  .main_wrap .work_wrap .head_title_wrap .head_title, .main_wrap .work_wrap .head_title_wrap .head_title *, .head_title .main_wrap .work_wrap .head_title_wrap * {
    font-size: 12vw;
  }
  .main_wrap .work_wrap .work_list_wrap .work_list {
    display: block;
  }
  .main_wrap .work_wrap .work_list_wrap .work_list li {
    width: 100%;
    margin-bottom: 50px;
  }
  .main_wrap .work_wrap .btn_wrap {
    margin-top: 8vw;
  }
}
@media screen and (max-width: 979px) {
  .main_wrap .work_wrap .work_list_wrap .work_list li {
    padding: 0 0 0 15px;
  }
}

.main_wrap .news_wrap {
  padding: 0 10vw;
  margin-top: 10vw;
}
.main_wrap .news_wrap .inner {
  padding-top: 65px;
  border-top: 3px solid #080808;
  display: flex;
}
.main_wrap .news_wrap .head_title, .main_wrap .news_wrap .head_title *, .head_title .main_wrap .news_wrap * {
  flex: 1;
  width: calc(50% - 8px);
  padding-right: 8px;
}
.main_wrap .news_wrap .news_list_wrap {
  flex: 1;
  width: calc(50% - 8px);
  margin-left: 8px;
}
.main_wrap .news_wrap .news_list_wrap .news_list .small {
  display: block;
  font-size: 10px;
  font-weight: 400;
  line-height: 1.2;
  text-transform: uppercase;
}
.main_wrap .news_wrap .news_list_wrap .news_list strong {
  font-size: 30px;
  font-weight: bold;
  line-height: 1.1;
}
.main_wrap .news_wrap .news_list_wrap .news_list .news_item {
  margin-top: 16px;
}
.main_wrap .news_wrap .news_list_wrap .news_list .news_item li {
  width: 100%;
  min-height: 40px;
  border-bottom: 1px solid rgba(17, 17, 17, 0.2);
  padding: 0 16px;
  font-size: 16px;
}
.main_wrap .news_wrap .news_list_wrap .news_list .news_item li .news_link {
  display: inline-flex;
  width: 100%;
  height: 40px;
  align-items: center;
  justify-content: space-between;
}
.main_wrap .news_wrap .news_list_wrap .news_list .news_item li .news_link__date {
  font-size: 14px;
  color: #ff3c31;
}
.main_wrap .news_wrap .news_list_wrap .btn_wrap {
  margin-top: 90px;
}
@media screen and (max-width: 979px) {
  .main_wrap .news_wrap {
    margin-top: 100px;
  }
  .main_wrap .news_wrap .inner {
    display: block;
  }
  .main_wrap .news_wrap .head_title, .main_wrap .news_wrap .head_title *, .head_title .main_wrap .news_wrap * {
    width: 100%;
    font-size: 18vw;
  }
  .main_wrap .news_wrap .news_list_wrap {
    width: 100%;
    margin: 60px 0 0;
  }
  .main_wrap .news_wrap .news_list_wrap .news_list .news_item li {
    padding: 0 10px;
  }
  .main_wrap .news_wrap .news_list_wrap .btn_wrap {
    margin-top: 60px;
  }
}
@media screen and (max-width: 639px) {
  .main_wrap .news_wrap .news_list_wrap {
    margin: 30px 0 0;
  }
  .main_wrap .news_wrap .news_list_wrap .btn_wrap {
    margin-top: 30px;
  }
}

.main_wrap .gallery_wrap {
  margin-top: 10vw;
  margin-bottom: 130px;
  padding: 0 10vw;
}
.main_wrap .gallery_wrap .inner {
  padding-top: 65px;
  border-top: 3px solid #080808;
}
.main_wrap .gallery_wrap .head_title_wrap {
  display: flex;
  align-items: flex-end;
  justify-content: space-between;
}
.main_wrap .gallery_wrap .head_title_wrap .head_title, .main_wrap .gallery_wrap .head_title_wrap .head_title *, .head_title .main_wrap .gallery_wrap .head_title_wrap * {
  font-size: 8vw;
}
.main_wrap .gallery_wrap .gallery_list_wrap .gallery_list {
  display: flex;
  margin-top: 10vw;
}
.main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li {
  flex: 1;
  width: 33.3333333333%;
  border-left: 1px solid #080808;
}
.main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li:nth-child(3n+3) {
  border-right: 1px solid #080808;
}
.main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li .gallery_item {
  overflow: hidden;
  display: inline-block;
  width: 100%;
  padding: 0 32px;
}
.main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li .gallery_item__title {
  overflow: hidden;
  display: -webkit-box;
  height: 90px;
  font-size: 25px;
  font-weight: 300;
  line-height: 1.2;
  margin-bottom: 96px;
  -webkit-line-clamp: 3;
  line-clamp: 3;
  -webkit-box-orient: vertical;
  text-overflow: ellipsis;
}
.main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li .gallery_item .gallery_info {
  justify-content: space-between;
  align-items: center;
  display: flex;
}
.main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li .gallery_item .gallery_info span {
  display: inline-block;
  font-size: 16px;
  font-weight: 300;
  line-height: 1.45;
}
.main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li .gallery_item__img {
  margin-top: 16px;
  z-index: 1;
  background-color: #d8d8d8;
  border-radius: 1.25em;
  position: relative;
  overflow: hidden;
  padding-top: 66.666%;
  transition: 0.2s;
}
.main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li .gallery_item__img::before {
  overflow: hidden;
  border-radius: 1.25em;
  display: inline-block;
  width: 100%;
  height: 100%;
  position: absolute;
  top: 0;
  left: 0;
  background: #ff3c31;
  opacity: 0;
  content: "";
  mix-blend-mode: multiply;
  z-index: 1;
  transition: 0.3s;
}
.main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li .gallery_item__img img {
  width: 100%;
  height: 100%;
  max-width: none;
  object-fit: cover;
  position: absolute;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  transition: 0.4s;
}
.main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li .gallery_item .gallery_item__img:hover::before {
  opacity: 0.8;
}
.main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li .gallery_item .gallery_item__img:hover img {
  transform: scale(1.2);
}
@media screen and (max-width: 979px) {
  .main_wrap .gallery_wrap {
    margin-top: 100px;
    margin-bottom: 100px;
  }
  .main_wrap .gallery_wrap .head_title_wrap {
    display: block;
  }
  .main_wrap .gallery_wrap .head_title_wrap .head_title, .main_wrap .gallery_wrap .head_title_wrap .head_title *, .head_title .main_wrap .gallery_wrap .head_title_wrap * {
    font-size: 15vw;
  }
  .main_wrap .gallery_wrap .head_title_wrap .btn_wrap {
    margin-top: 30px;
  }
  .main_wrap .gallery_wrap .gallery_list_wrap .gallery_list {
    display: block;
  }
  .main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li {
    width: 100%;
    margin-bottom: 40px;
    padding-top: 16px;
    border-top: 1px solid #080808;
  }
  .main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li .gallery_item__title {
    height: 75px;
    margin-bottom: 40px;
    font-size: 20px;
    line-height: 25px;
  }
}
@media screen and (max-width: 639px) {
  .main_wrap .gallery_wrap .head_title_wrap {
    display: block;
  }
  .main_wrap .gallery_wrap .head_title_wrap .head_title, .main_wrap .gallery_wrap .head_title_wrap .head_title *, .head_title .main_wrap .gallery_wrap .head_title_wrap * {
    font-size: 12vw;
  }
  .main_wrap .gallery_wrap .head_title_wrap .btn_wrap {
    margin-top: 30px;
  }
  .main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li {
    border-left: 0;
  }
  .main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li:nth-child(3n+3) {
    border-right: 0;
  }
  .main_wrap .gallery_wrap .gallery_list_wrap .gallery_list li .gallery_item {
    padding: 0 15px;
  }
}

.main_wrap .about_wrap {
  margin-top: 10vw;
  margin-bottom: 10vw;
  padding: 0 10vw;
}
.main_wrap .about_wrap .inner {
  position: relative;
  display: flex;
  justify-content: space-between;
  padding-top: 65px;
  border-top: 3px solid #080808;
}
.main_wrap .about_wrap .about_title_wrap {
  flex: 1;
  width: calc(50% - 8px);
  padding-right: 8%;
  margin-right: 8px;
}
.main_wrap .about_wrap .about_title_wrap .head_title__sub {
  font-size: 1.1875em;
  font-weight: 400;
  line-height: 1;
}
.main_wrap .about_wrap .about_title_wrap .head_title, .main_wrap .about_wrap .about_title_wrap .head_title *, .head_title .main_wrap .about_wrap .about_title_wrap * {
  margin-top: 30px;
  font-size: 110px;
}
.main_wrap .about_wrap .about_title_wrap .btn_wrap {
  margin-top: 90px;
}
.main_wrap .about_wrap .about_img_wrap {
  flex: 1;
  width: calc(50% - 8px);
  margin-left: 8px;
  background-color: #d8d8d8;
  border-radius: 20px;
  position: relative;
  overflow: hidden;
  padding-top: 50%;
  display: flex;
}
.main_wrap .about_wrap .about_img_wrap p {
  position: absolute;
  top: 0;
  left: 100%;
  width: 100%;
  height: 100%;
  z-index: 3;
  transition: 0.7s ease;
}
.main_wrap .about_wrap .about_img_wrap p img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}
.main_wrap .about_wrap .about_img_wrap p:nth-of-type(1) {
  left: 0;
  width: 100%;
  height: 100%;
  padding: 0;
  z-index: 3;
  transform: scale(1.1);
}
.main_wrap .about_wrap .about_img_wrap p:nth-of-type(2) {
  left: 0;
  width: 100%;
  height: 100%;
  padding: 0;
  z-index: 4;
  transform: scale(1);
}
.main_wrap .about_wrap .about_navi {
  padding-left: 25px;
  color: white;
  z-index: 3;
}
.main_wrap .about_wrap .about_navi .about_prev,
.main_wrap .about_wrap .about_navi .about_next {
  position: relative;
  display: inline-block;
  width: 70px;
  height: 70px;
  border-radius: 50%;
  border: 1px solid #080808;
  margin-right: 20px;
  cursor: pointer;
}
.main_wrap .about_wrap .about_navi .about_prev::before, .main_wrap .about_wrap .about_navi .about_prev::after,
.main_wrap .about_wrap .about_navi .about_next::before,
.main_wrap .about_wrap .about_navi .about_next::after {
  content: "";
  display: block;
  width: 17px;
  height: 2px;
  background: #080808;
  position: absolute;
  top: 50%;
}
.main_wrap .about_wrap .about_navi .about_prev::before,
.main_wrap .about_wrap .about_navi .about_next::before {
  transform: rotate(45deg) translateX(0px);
}
.main_wrap .about_wrap .about_navi .about_prev::after,
.main_wrap .about_wrap .about_navi .about_next::after {
  transform: rotate(-45deg) translateX(0px);
}
.main_wrap .about_wrap .about_navi .about_prev span,
.main_wrap .about_wrap .about_navi .about_next span {
  width: 20px;
  height: 2px;
  background: #080808;
  position: absolute;
  top: 50%;
  opacity: 1;
}
.main_wrap .about_wrap .about_navi .about_prev.on,
.main_wrap .about_wrap .about_navi .about_next.on {
  animation: btnEffect 0.3s 1;
}
.main_wrap .about_wrap .about_navi .about_prev::before, .main_wrap .about_wrap .about_navi .about_prev::after {
  left: 25px;
  transform-origin: left center;
}
.main_wrap .about_wrap .about_navi .about_prev span {
  left: 25px;
}
.main_wrap .about_wrap .about_navi .about_prev.on span {
  animation: prevArrow 0.5s 1;
}
.main_wrap .about_wrap .about_navi .about_next::before, .main_wrap .about_wrap .about_navi .about_next::after {
  right: 25px;
  transform-origin: right center;
}
.main_wrap .about_wrap .about_navi .about_next span {
  right: 25px;
}
.main_wrap .about_wrap .about_navi .about_next.on span {
  animation: nextArrow 0.5s 1;
}
@keyframes btnEffect {
  0% {
    transform: scale(1);
    border: 1px solid rgb(255, 255, 255);
  }
  70% {
    transform: scale(2);
    border: 1px solid rgba(255, 255, 255, 0);
  }
  100% {
    transform: scale(1);
    border: 1px solid rgb(255, 255, 255);
  }
}
@keyframes prevArrow {
  0% {
    left: 25px;
    width: 20px;
    opacity: 1;
  }
  70% {
    left: -30px;
    width: 50px;
    opacity: 0;
  }
  71% {
    left: 100px;
    width: 120px;
    opacity: 0;
  }
  100% {
    left: 25px;
    width: 20px;
    opacity: 1;
  }
}
@keyframes nextArrow {
  0% {
    right: 25px;
    width: 20px;
    opacity: 1;
  }
  70% {
    right: -30px;
    width: 50px;
    opacity: 0;
  }
  71% {
    right: 100px;
    width: 120px;
    opacity: 0;
  }
  100% {
    right: 25px;
    width: 20px;
    opacity: 1;
  }
}
@media screen and (max-width: 979px) {
  .main_wrap .about_wrap .inner {
    display: block;
  }
  .main_wrap .about_wrap .about_title_wrap {
    width: 100%;
    margin: 0;
  }
  .main_wrap .about_wrap .about_title_wrap .head_title, .main_wrap .about_wrap .about_title_wrap .head_title *, .head_title .main_wrap .about_wrap .about_title_wrap * {
    font-size: 12vw;
    line-height: 1;
  }
  .main_wrap .about_wrap .about_title_wrap .btn_wrap {
    margin-top: 5vw;
  }
  .main_wrap .about_wrap .about_img_wrap {
    width: 100%;
    margin: 10vw 0 0;
    padding-top: 100%;
  }
}

.sub_wrap .members_wrap {
  padding: 0 10vw;
}
.sub_wrap .members_wrap .head_title, .sub_wrap .members_wrap .head_title *, .head_title .sub_wrap .members_wrap * {
  letter-spacing: 5px;
}
.sub_wrap .members_wrap .inner {
  margin-top: 20px;
  border-top: 1px solid #080808;
}
.sub_wrap .members_wrap .member_title {
  display: inline-block;
  width: 100%;
  font-size: 7vw;
  font-family: "Bebas Neue", sans-serif;
  letter-spacing: 1px;
}
.sub_wrap .members_wrap .member_zone {
  margin-top: 20vw;
}
.sub_wrap .members_wrap .member_zone .member_title {
  border-top: 1px solid #000;
}
.sub_wrap .member_list_wrap {
  margin-top: 5vw;
  padding-bottom: 12vw;
}
.sub_wrap .member_list_wrap .member_all {
  display: flex;
}
.sub_wrap .member_list_wrap .member_all .member_title {
  text-align: right;
}
.sub_wrap .member_list_wrap .member_all__img {
  flex: 1 1 50%;
  width: 50%;
  overflow: hidden;
  border-radius: 0.25em;
}
.sub_wrap .member_list_wrap .member_all__img img {
  width: 100%;
  height: auto;
  object-fit: cover;
}
.sub_wrap .member_list_wrap .member_all__desc {
  width: 45%;
  margin-left: 5%;
}
.sub_wrap .member_list_wrap .member_all__desc p {
  margin-top: 35px;
  font-size: 30px;
  line-height: 1.3;
}
.sub_wrap .member_list_wrap .member_list {
  display: flex;
  justify-content: space-between;
  flex-wrap: wrap;
}
.sub_wrap .member_list_wrap .member_list .member_item {
  width: calc(33.3333333333% - 40px);
  margin-top: 100px;
  margin-left: 60px;
}
.sub_wrap .member_list_wrap .member_list .member_item:nth-of-type(3n + 1) {
  margin-left: 0;
}
.sub_wrap .member_list_wrap .member_list .member_item__info {
  padding-bottom: 20px;
  border-bottom: 1px solid #080808;
}
.sub_wrap .member_list_wrap .member_list .member_item__info .member_item__title {
  width: 100%;
  font-size: 40px;
  font-family: "Bebas Neue", sans-serif;
  line-height: 0.9;
  letter-spacing: 3px;
  word-break: keep-all;
}
.sub_wrap .member_list_wrap .member_list .member_item__info .member_item__desc {
  margin-top: 15px;
  letter-spacing: 1px;
  text-transform: uppercase;
}
.sub_wrap .member_list_wrap .member_list .member_item__img {
  position: relative;
  overflow: hidden;
  width: 100%;
  height: 500px;
  margin-top: 3vw;
  border-radius: 0.25em;
}
.sub_wrap .member_list_wrap .member_list .member_item__img img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  filter: grayscale(100%);
  transition: 0.4s;
}
.sub_wrap .member_list_wrap .member_list .member_item__img:hover img {
  filter: none;
  transform: scale(1.1);
}
@media screen and (max-width: 979px) {
  .sub_wrap .member_list_wrap .member_all {
    display: block;
  }
  .sub_wrap .member_list_wrap .member_all .member_title {
    text-align: left;
  }
  .sub_wrap .member_list_wrap .member_all__img {
    width: 100%;
  }
  .sub_wrap .member_list_wrap .member_all__desc {
    width: 100%;
    margin-left: 0;
  }
  .sub_wrap .member_list_wrap .member_list .member_item {
    width: calc(50% - 30px);
  }
  .sub_wrap .member_list_wrap .member_list .member_item:nth-of-type(3n + 1) {
    margin-left: 60px;
  }
  .sub_wrap .member_list_wrap .member_list .member_item:nth-of-type(odd) {
    margin-left: 0;
  }
}
@media screen and (max-width: 639px) {
  .sub_wrap .members_wrap .member_title {
    font-size: 10vw;
    padding-top: 5vw;
  }
  .sub_wrap .member_list_wrap .member_all {
    display: block;
  }
  .sub_wrap .member_list_wrap .member_all .member_title {
    text-align: left;
  }
  .sub_wrap .member_list_wrap .member_all__img {
    width: 100%;
  }
  .sub_wrap .member_list_wrap .member_all__desc {
    width: 100%;
    margin-left: 0;
  }
  .sub_wrap .member_list_wrap .member_all__desc p {
    margin-top: 15px;
    font-size: 20px;
  }
  .sub_wrap .member_list_wrap .member_list .member_item {
    width: 100%;
    margin-top: 50px;
  }
  .sub_wrap .member_list_wrap .member_list .member_item:nth-of-type(n) {
    margin-left: 0;
  }
  .sub_wrap .member_list_wrap .member_list .member_item__img {
    height: 300px;
  }
}

.sub_wrap .gallery_wrap {
  padding: 0 10vw;
  position: relative;
  width: 100%;
}
.sub_wrap .gallery_wrap .sub_head {
  display: flex;
  justify-content: space-between;
  align-items: flex-end;
}
.sub_wrap .gallery_wrap .searchBox {
  position: relative;
  width: 40%;
  height: 60px;
  margin: 0 10px 5px 0;
  padding: 5px 20px;
  font-size: 0;
  border: 2px solid #555;
  border-radius: 60px;
  background: #fff;
  box-shadow: 5px 5px 20px rgba(200, 200, 200, 0.3);
}
.sub_wrap .gallery_wrap .searchBox input {
  width: 100%;
  height: 100%;
  background-color: transparent;
  border: none;
  padding-left: 10px;
  padding-right: 50px;
  font-size: 18px;
  font-family: sans-serif;
}
.sub_wrap .gallery_wrap .searchBox input:focus, .sub_wrap .gallery_wrap .searchBox input:focus-visible {
  border: 0 !important;
}
.sub_wrap .gallery_wrap .searchBox .searchBtn {
  position: absolute;
  top: 4px;
  right: 4px;
  width: 50px;
  height: 50px;
  background: #333;
  border-radius: 50px;
  text-align: center;
  border: 0;
  cursor: pointer;
  transform: translateY(-1px);
}
.sub_wrap .gallery_wrap .searchBox .searchBtn i {
  color: #fff;
  font-size: 20px;
}
.sub_wrap .gallery_wrap .loading {
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  z-index: 10;
  width: 100%;
  height: 100%;
  opacity: 0.8;
  z-index: 100;
}
.sub_wrap .gallery_wrap .loading.off {
  opacity: 0;
  z-index: -1;
}
.sub_wrap .gallery_wrap .loading img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}
.sub_wrap .gallery_wrap .inner {
  padding-top: 100px;
}
.sub_wrap .gallery_wrap .gallery_menu {
  position: relative;
  display: flex;
  align-content: center;
  justify-content: space-between;
  width: 400px;
  margin: 0 auto;
  padding: 10px 20px;
  background: #080808;
  height: 60px;
  border-radius: 60px;
}
.sub_wrap .gallery_wrap .gallery_menu button {
  display: inline-block;
  font-size: 18px;
  font-weight: 300;
  font-family: "Verdana", sans-serif;
  color: #666;
  width: 50%;
  height: 38px;
  border-radius: 38px;
  line-height: 38px;
  text-align: center;
  z-index: 2;
}
.sub_wrap .gallery_wrap .gallery_menu button.on {
  color: #fff;
  font-size: 19px;
}
.sub_wrap .gallery_wrap .gallery_menu .gallery_menu__bg {
  position: absolute;
  top: 10px;
  left: 10px;
  display: inline-block;
  width: 50%;
  height: 40px;
  background: #ff3c31;
  box-shadow: 0px 1px 2px rgba(0, 0, 0, 0.2);
  border-radius: 40px;
  z-index: 1;
  opacity: 0;
  -webkit-transform: translateX(0px);
  transform: translateX(0px);
  -webkit-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out;
}
.sub_wrap .gallery_wrap .gallery_menu button.on ~ .gallery_menu__bg {
  -webkit-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out;
  opacity: 1;
}
.sub_wrap .gallery_wrap .gallery_menu button.on:nth-child(1) ~ .gallery_menu__bg {
  -webkit-transform: translateX(0px);
  transform: translateX(0px);
}
.sub_wrap .gallery_wrap .gallery_menu button.on:nth-child(2) ~ .gallery_menu__bg {
  -webkit-transform: translateX(180px);
  transform: translateX(180px);
}
.sub_wrap .gallery_wrap .gallery_list {
  width: calc(100% + 30px);
  margin-left: -30px;
  padding-bottom: 120px;
}
.sub_wrap .gallery_wrap .gallery_list::after {
  display: block;
  clear: both;
  content: "";
}
.sub_wrap .gallery_wrap .gallery_list li {
  float: left;
  width: calc(33.333% - 30px);
  padding: 30px 0 0;
  margin-left: 30px;
}
.sub_wrap .gallery_wrap .gallery_list .gallery_item {
  overflow: hidden;
  display: block;
  width: 100%;
  height: 100%;
}
.sub_wrap .gallery_wrap .gallery_list .gallery_item__num {
  display: none;
  font-size: 25px;
  font-weight: bold;
  line-height: 1.2;
  text-transform: uppercase;
  font-family: "Verdana", sans-serif;
}
.sub_wrap .gallery_wrap .gallery_list .gallery_item__desc {
  margin-top: 30px;
  font-size: 19px;
  font-weight: 400;
  line-height: 1.22;
}
.sub_wrap .gallery_wrap .gallery_list .gallery_item__pic {
  position: relative;
  overflow: hidden;
  width: 100%;
  background-color: #d8d8d8;
  line-height: 0;
}
.sub_wrap .gallery_wrap .gallery_list .gallery_item__pic img {
  width: 100%;
  height: auto;
  transition: 0.5s cubic-bezier(0.25, 0.46, 0.45, 0.94);
}
.sub_wrap .gallery_wrap .gallery_list .gallery_item:hover .gallery_item__pic img {
  transform: scale(1.1);
}
.sub_wrap .gallery_wrap .gallery_list .gallery_item .gallery_profile {
  position: relative;
  padding: 50px 0 25px;
  z-index: 2;
  text-align: center;
  transition: 0.4s 0.15s cubic-bezier(0.17, 0.67, 0.5, 1.03);
}
.sub_wrap .gallery_wrap .gallery_list .gallery_item .gallery_profile__img {
  overflow: hidden;
  display: block;
  width: 80px;
  height: 80px;
  padding: 3px;
  position: absolute;
  top: -35px;
  left: 50%;
  transform: translateX(-50%);
  z-index: 3;
  background: white;
  border-radius: 100%;
}
.sub_wrap .gallery_wrap .gallery_list .gallery_item .gallery_profile__img img {
  border-radius: 100%;
  width: 100%;
  height: 100%;
  object-fit: cover;
}
.sub_wrap .gallery_wrap .gallery_list .gallery_item .gallery_profile__title, .sub_wrap .gallery_wrap .gallery_list .gallery_item .gallery_profile__id {
  font-size: 17px;
  font-family: "Open sans";
  line-height: 1.5;
  text-transform: uppercase;
}
.sub_wrap .gallery_wrap .gallery_list .gallery_item .gallery_profile__id {
  position: relative;
  cursor: pointer;
  display: inline-block;
  transform: scale(0.9) translateZ(0);
  transition: 0.3s;
  margin-bottom: 2px;
}
.sub_wrap .gallery_wrap .gallery_list .gallery_item .gallery_profile__id::before {
  content: "";
  position: absolute;
  width: 100%;
  height: 1px;
  background-color: #080808;
  bottom: 0;
  left: 0;
  transform-origin: right;
  transform: scaleX(0);
  transition: transform 0.3s ease-in-out;
}
.sub_wrap .gallery_wrap .gallery_list .gallery_item .gallery_profile:hover .gallery_profile__id {
  font-weight: bold;
}
.sub_wrap .gallery_wrap .gallery_list .gallery_item .gallery_profile:hover .gallery_profile__id::before {
  transform-origin: left;
  transform: scaleX(1);
}
@media screen and (max-width: 979px) {
  .sub_wrap .gallery_wrap {
    padding: 0 5%;
  }
  .sub_wrap .gallery_wrap .sub_head {
    flex-wrap: wrap;
  }
  .sub_wrap .gallery_wrap .searchBox {
    flex: 1 1 100%;
    margin: 50px 0 0 0;
  }
  .sub_wrap .gallery_wrap .inner {
    padding-top: 80px;
  }
  .sub_wrap .gallery_wrap .gallery_list {
    width: calc(100% + 20px);
    margin-left: -20px;
    padding-bottom: 120px;
  }
  .sub_wrap .gallery_wrap .gallery_list li {
    width: calc(50% - 20px);
  }
}
@media screen and (max-width: 639px) {
  .sub_wrap .gallery_wrap {
    padding: 0 5%;
  }
  .sub_wrap .gallery_wrap .sub_head {
    flex-wrap: wrap;
  }
  .sub_wrap .gallery_wrap .searchBox {
    flex: 1 1 100%;
    margin: 50px 0 0 0;
  }
  .sub_wrap .gallery_wrap .inner {
    padding-top: 80px;
  }
  .sub_wrap .gallery_wrap .gallery_menu button {
    width: 50%;
  }
  .sub_wrap .gallery_wrap .gallery_list {
    width: 100%;
    margin-left: 0;
    padding-bottom: 100px;
  }
  .sub_wrap .gallery_wrap .gallery_list li {
    width: 100%;
    margin-left: 0;
  }
}

.sub_wrap .youtube_wrap {
  padding: 0 10vw;
}
.sub_wrap .youtube_wrap .sub_head {
  display: flex;
  align-items: flex-end;
  padding-bottom: 20px;
}
.sub_wrap .youtube_wrap .sub_head .head_title__sub {
  display: inline-block;
  width: 180px;
  padding-bottom: 10px;
  margin-left: 50px;
}
.sub_wrap .youtube_wrap .gallery_list {
  padding-top: 50px;
  padding-bottom: 50px;
}
.sub_wrap .youtube_wrap .gallery_list li {
  width: 100%;
  border-top: 1px solid #080808;
}
.sub_wrap .youtube_wrap .gallery_list li .gallery_item {
  display: flex;
  overflow: hidden;
  padding: 3vw 3vw 3vw 2vw;
}
.sub_wrap .youtube_wrap .gallery_list li .gallery_item__img {
  position: relative;
  overflow: hidden;
  width: 450px;
  height: 0;
  z-index: 1;
  background-color: gray;
  border-radius: 0.25em;
  padding-top: 253.125px;
  transition: 0.2s;
}
.sub_wrap .youtube_wrap .gallery_list li .gallery_item__img::before {
  overflow: hidden;
  display: inline-block;
  width: 100%;
  height: 100%;
  background: rgba(0, 0, 0, 0.5);
  position: absolute;
  top: 0;
  left: 0;
  opacity: 0;
  content: "";
  mix-blend-mode: multiply;
  z-index: 1;
  transition: 0.3s;
}
.sub_wrap .youtube_wrap .gallery_list li .gallery_item__img img {
  width: 100%;
  height: 100%;
  max-width: none;
  object-fit: cover;
  position: absolute;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  transition: 0.4s;
}
.sub_wrap .youtube_wrap .gallery_list li .gallery_item .gallery_item__img:hover::before {
  opacity: 0.8;
}
.sub_wrap .youtube_wrap .gallery_list li .gallery_item .gallery_item__img:hover img {
  transform: scale(1.1);
}
.sub_wrap .youtube_wrap .gallery_list li .gallery_item .gallery_side {
  flex: 1;
  display: flex;
  flex-direction: column;
  margin-left: 5vw;
}
.sub_wrap .youtube_wrap .gallery_list li .gallery_item .gallery_side__title {
  overflow: hidden;
  display: -webkit-box;
  height: 100px;
  font-size: 24px;
  font-weight: 500;
  line-height: 1.4;
  color: #333;
  font-family: "Verdana", sans-serif;
}
.sub_wrap .youtube_wrap .gallery_list li .gallery_item .gallery_side__desc {
  flex: 1;
  overflow: hidden;
  margin-top: 1vw;
  font-size: 15px;
  font-weight: 400;
  line-height: 1.5;
  color: #333;
  font-family: "Verdana", sans-serif;
}
.sub_wrap .youtube_wrap .gallery_list li .gallery_item .gallery_side .gallery_info {
  justify-content: space-between;
  align-items: center;
  display: flex;
  margin-top: 3vw;
}
.sub_wrap .youtube_wrap .gallery_list li .gallery_item .gallery_side .gallery_info span {
  display: inline-block;
  font-size: 14px;
  line-height: 1.4;
  color: gray;
  font-family: "Verdana", sans-serif;
}
@media screen and (max-width: 979px) {
  .sub_wrap .youtube_wrap {
    padding: 0 5%;
  }
  .sub_wrap .youtube_wrap .sub_head {
    justify-content: space-between;
  }
  .sub_wrap .youtube_wrap .gallery_list li .gallery_item__img {
    width: 40%;
    padding-top: 22.5%;
  }
}
@media screen and (max-width: 639px) {
  .sub_wrap .youtube_wrap .gallery_list {
    padding-top: 50px;
    padding-bottom: 50px;
  }
  .sub_wrap .youtube_wrap .gallery_list li .gallery_item {
    display: block;
    padding: 4vw 2vw;
  }
  .sub_wrap .youtube_wrap .gallery_list li .gallery_item__img {
    width: 100%;
    padding-top: 56.25%;
  }
  .sub_wrap .youtube_wrap .gallery_list li .gallery_item .gallery_side {
    width: 100%;
    margin-left: 0;
    margin-top: 5vw;
  }
}

.contact_wrap .inner {
  display: flex;
  padding: 0 10vw;
}
.contact_wrap .inner .contact_head {
  width: 45%;
  padding-right: 5vw;
}
.contact_wrap .inner .contact_head strong {
  font-size: 10vw;
  font-weight: bold;
  font-family: "Bebas Neue", sans-serif;
  line-height: 0.8;
  letter-spacing: -2px;
}
.contact_wrap .inner .contact_head .pic {
  position: relative;
  overflow: hidden;
  border-radius: 0.25em;
  width: 90%;
  margin: 10px 0 30px;
  height: 0;
  padding-top: 0;
}
.contact_wrap .inner .contact_head .pic.on {
  height: 200px;
  margin: 30px 0;
  opacity: 1;
  transform: translateY(0);
  transition: 0.6s cubic-bezier(0.26, 0.3, 0.98, 0.59);
}
.contact_wrap .inner .contact_head .pic img {
  position: absolute;
  top: 0;
  left: 0;
  object-fit: cover;
  width: 100%;
  height: 100%;
}
.contact_wrap .inner .contact_form {
  width: 55%;
  padding-left: 5vw;
  border-left: 1px solid #080808;
}
.contact_wrap .inner .contact_form form {
  height: 100%;
}
.contact_wrap .inner .contact_form fieldset {
  height: 100%;
  background: #fff;
  padding: 3vw 3vw 3vw 2vw;
  border-radius: 1.25em;
}
.contact_wrap .inner .contact_form table {
  width: 100%;
}
.contact_wrap .inner .contact_form table tr th {
  display: block;
  font-size: 16px;
  font-weight: 400;
  width: 100%;
  font-family: "Verdana", sans-serif;
  text-align: left;
}
.contact_wrap .inner .contact_form table tr td {
  display: block;
  width: 100%;
  padding-top: 10px;
  margin-bottom: 20px;
  font-family: "Verdana", sans-serif;
  text-align: left;
}
.contact_wrap .inner .contact_form table tr td p {
  font-size: 14px;
  display: block;
  width: auto;
  font-weight: 500;
  line-height: 18px;
  padding-top: 0;
  margin: 4px 0;
  color: #f2545b;
}
.contact_wrap .inner .contact_form table tr td input,
.contact_wrap .inner .contact_form table tr td select {
  background: #f5f8fa;
  display: inline-block;
  width: 100%;
  height: 40px;
  padding: 9px 10px;
  font-size: 16px;
  line-height: 22px;
  color: #33475b;
  border: 1px solid #cbd6e2;
  box-sizing: border-box;
  border-radius: 10px;
  font-family: "Verdana", sans-serif;
}
.contact_wrap .inner .contact_form table tr td textarea {
  background: #f5f8fa;
  resize: none;
  width: 100%;
  height: 80px;
  padding: 9px 10px;
  font-size: 16px;
  line-height: 22px;
  color: #33475b;
  border: 1px solid #cbd6e2;
  box-sizing: border-box;
  border-radius: 2px;
  font-family: "Verdana", sans-serif;
}
.contact_wrap .inner .contact_form table tr td input[type=checkbox],
.contact_wrap .inner .contact_form table tr td input[type=radio] {
  width: auto;
  height: auto;
  padding: 0;
  margin: 3px 5px 3px 10px;
  line-height: normal;
  border: none;
}
.contact_wrap .inner .contact_form table .checkboxList li {
  margin-bottom: 10px;
}
.contact_wrap .inner .contact_form table .form_btn td {
  text-align: center;
  padding: 30px 0 0;
}
.contact_wrap .inner .contact_form table .form_btn input {
  border: 0;
  width: 40%;
  height: 40px;
  font-size: 16px;
  line-height: 22px;
  color: #33475b;
  box-sizing: border-box;
  border-radius: 2px;
  font-family: "Verdana", sans-serif;
  cursor: pointer;
}
.contact_wrap .inner .contact_form table .form_btn input[type=submit] {
  margin-left: 20px;
  background: #cbd6e2;
  border: 1px solid #cbd6e2;
}
.contact_wrap .inner .contact_form table .form_btn input[type=reset] {
  background: #cbcbcb;
  border: 1px solid #cbd6e2;
}

@media screen and (max-width: 979px) {
  .contact_wrap .inner {
    padding: 0 5%;
    display: block;
  }
  .contact_wrap .inner .contact_head {
    width: 100%;
  }
  .contact_wrap .inner .contact_form {
    width: 100%;
    margin-top: 80px;
    padding: 50px 0 0 0;
    border-top: 1px solid #080808;
    border-left: none;
  }
  .contact_wrap .inner .contact_form fieldset {
    padding: 40px 30px;
  }
  .contact_wrap .inner .contact_form fieldset table th {
    vertical-align: top;
    padding-top: 18px;
  }
}
.location_wrap .head_title, .location_wrap .head_title *, .head_title .location_wrap * {
  padding: 0 10%;
}
.location_wrap .inner {
  position: relative;
}
.location_wrap .inner #map {
  height: 50vh;
  background: #111;
}
.location_wrap .contact_form {
  display: flex;
  gap: 10%;
  margin-top: 100px;
  padding: 0 10%;
  position: relative;
}
.location_wrap .contact_form::before {
  position: absolute;
  top: 0;
  left: 50%;
  transform: translateX(-50%);
  content: "";
  width: 1px;
  height: 100%;
  background: #080808;
}
.location_wrap .contact_form .form_wrap {
  width: 50%;
}
.location_wrap .contact_form .form_wrap form {
  height: 100%;
}
.location_wrap .contact_form .form_wrap fieldset {
  height: 100%;
}
.location_wrap .contact_form .form_wrap table {
  width: 100%;
}
.location_wrap .contact_form .form_wrap table tr th {
  display: block;
  font-size: 16px;
  font-weight: 400;
  width: 100%;
  font-family: "Verdana", sans-serif;
  text-align: left;
}
.location_wrap .contact_form .form_wrap table tr td {
  display: block;
  width: 100%;
  padding-top: 10px;
  margin-bottom: 20px;
  font-family: "Verdana", sans-serif;
  text-align: left;
}
.location_wrap .contact_form .form_wrap table tr td p {
  font-size: 14px;
  display: block;
  width: auto;
  font-weight: 500;
  line-height: 18px;
  padding-top: 0;
  margin: 4px 0;
  color: #f2545b;
}
.location_wrap .contact_form .form_wrap table tr td input,
.location_wrap .contact_form .form_wrap table tr td select {
  background: #f5f8fa;
  display: inline-block;
  width: 100%;
  height: 40px;
  padding: 9px 10px;
  font-size: 16px;
  line-height: 22px;
  color: #33475b;
  border: 1px solid #cbd6e2;
  box-sizing: border-box;
  border-radius: 10px;
  font-family: "Verdana", sans-serif;
}
.location_wrap .contact_form .form_wrap table tr td textarea {
  background: #f5f8fa;
  resize: none;
  width: 100%;
  height: 80px;
  padding: 9px 10px;
  font-size: 16px;
  line-height: 22px;
  color: #33475b;
  border: 1px solid #cbd6e2;
  box-sizing: border-box;
  border-radius: 2px;
  font-family: "Verdana", sans-serif;
}
.location_wrap .contact_form .form_wrap table tr td input[type=checkbox],
.location_wrap .contact_form .form_wrap table tr td input[type=radio] {
  width: auto;
  height: auto;
  padding: 0;
  margin: 3px 5px 3px 10px;
  line-height: normal;
  border: none;
}
.location_wrap .contact_form .form_wrap table .checkboxList li {
  margin-bottom: 10px;
}
.location_wrap .contact_form .form_wrap table .form_btn td {
  text-align: center;
  padding: 30px 0 0;
}
.location_wrap .contact_form .form_wrap table .form_btn input {
  border: 0;
  width: 40%;
  height: 40px;
  font-size: 16px;
  line-height: 22px;
  color: #33475b;
  box-sizing: border-box;
  border-radius: 2px;
  font-family: "Verdana", sans-serif;
  cursor: pointer;
}
.location_wrap .contact_form .form_wrap table .form_btn input[type=submit] {
  margin-left: 20px;
  background: #cbd6e2;
  border: 1px solid #cbd6e2;
}
.location_wrap .contact_form .form_wrap table .form_btn input[type=reset] {
  background: #cbcbcb;
  border: 1px solid #cbd6e2;
}
.location_wrap .contact_form .form_info {
  width: 50%;
}
.location_wrap .contact_form .form_info__head {
  font-size: 6vw;
  font-weight: bold;
  font-family: "Bebas Neue", sans-serif;
  line-height: 0.8;
  letter-spacing: 1px;
}
.location_wrap .contact_form .form_info ul {
  padding: 30px 10px;
}
.location_wrap .contact_form .form_info ul li {
  margin-top: 35px;
}
.location_wrap .contact_form .form_info__title {
  font-size: 24px;
  font-weight: bold;
}
.location_wrap .contact_form .form_info__desc {
  margin-top: 15px;
}
.location_wrap .contact_form .form_info__desc a {
  font-size: 20px;
  font-weight: normal;
  color: #f97b22;
  display: inline-block;
  font-family: "Verdana";
}
.location_wrap .contact_form .form_info__desc i {
  margin-right: 15px;
  font-size: 20px;
  display: inline-flex;
  justify-content: center;
  align-items: center;
  width: 40px;
  height: 40px;
  padding: 7px;
  border: 2px solid #111;
  text-align: center;
  border-radius: 50%;
  opacity: 0.8;
}

@media screen and (max-width: 979px) {
  .location_wrap .head_title, .location_wrap .head_title *, .head_title .location_wrap * {
    padding: 0 10%;
  }
  .location_wrap .inner {
    position: relative;
  }
  .location_wrap .inner #map {
    height: 50vh;
    background: #111;
  }
  .location_wrap .contact_form {
    display: block;
    gap: 10%;
    margin-top: 100px;
    padding: 0 10%;
    position: relative;
  }
  .location_wrap .contact_form .form_wrap {
    width: 100%;
  }
  .location_wrap .contact_form .form_info {
    width: 100%;
  }
}

/*# sourceMappingURL=style.cs.map */