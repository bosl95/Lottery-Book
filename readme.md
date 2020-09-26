# Lottery Book

<image src="https://user-images.githubusercontent.com/34594339/94341174-64910800-0042-11eb-875f-4da0a67b00e9.png">

<image src="https://user-images.githubusercontent.com/34594339/94341177-6ce94300-0042-11eb-9811-dfdba189a264.png">

<image src="https://user-images.githubusercontent.com/34594339/94341184-72df2400-0042-11eb-9361-629446069ad5.png">

<image src="https://user-images.githubusercontent.com/34594339/94341192-796d9b80-0042-11eb-9a80-95292f54a245.png">

<image src="https://user-images.githubusercontent.com/34594339/94341195-7e324f80-0042-11eb-9de7-750baae95864.png">

<image src="https://user-images.githubusercontent.com/34594339/94341200-85595d80-0042-11eb-8b26-748211fc3edf.png">

<image src="https://user-images.githubusercontent.com/34594339/94341214-94d8a680-0042-11eb-9adf-5f30c3124487.png">

<image src="https://user-images.githubusercontent.com/34594339/94341223-a15cff00-0042-11eb-84bc-5452e1c93b4e.png">

<image src="https://user-images.githubusercontent.com/34594339/94341229-ad48c100-0042-11eb-8230-51ad1ec58f57.png">

<image src="https://user-images.githubusercontent.com/34594339/94341232-b33ea200-0042-11eb-9494-8120964fa3e3.png">

<image src="https://user-images.githubusercontent.com/34594339/94341235-b76abf80-0042-11eb-9ddf-cbd65a7151c2.png">

<image src="https://user-images.githubusercontent.com/34594339/94341242-bd60a080-0042-11eb-944a-f9bcd14c2e8d.png">

<image src="https://user-images.githubusercontent.com/34594339/94341244-c18cbe00-0042-11eb-8c4e-34d1e89ae418.png">

<image src="https://user-images.githubusercontent.com/34594339/94341246-c6ea0880-0042-11eb-8e14-6ccaea8264a8.png">

<image src="https://user-images.githubusercontent.com/34594339/94341247-cbaebc80-0042-11eb-8ab4-28cb0eb09834.png">

<image src="https://user-images.githubusercontent.com/34594339/94341254-d0737080-0042-11eb-8b2b-3694abdc6093.png">

<image src="https://user-images.githubusercontent.com/34594339/94341263-d79a7e80-0042-11eb-8cb3-5507de089aa9.png">

<br>

---

- text : 대소문자 구분
- char/varchar : 대소문 구분x
⇒  char 은 길이가 동일한 것에서 사용 ex) 주민번호, 우편번호 등..

* 외래키 설정시 (phpmyadmin)
- CASCADE : 개체를 변경, 삭제할때 다른 객체가 변경/삭제할 개체를 참조할 경우 함께 변경/삭제
- SET NULL : 개체를 변경, 삭제할때 다른 객체가 변경/삭제할 개체를 참조할 경우 참조하고 있는 값은 NULL
- NO ACTION : 개체를 변경, 삭제할때 다른 객체가 변경/삭제할 개체를 참조할 경우  변경/삭제할 개체만 변경/삭제 참조하고 있는 객체는 변동 X
- RESTRICT : 개체를 변경, 삭제할때 다른 객체가 변경/삭제할 개체를 참조할 경우 변경/삭제가 취소

- mysqldatareader 는 레코드단위로 읽음

- 카드 테이블의 연계계좌는 통장 테이블과 연결되어있어야함
(통장 테이블에서 연계된 통장이 삭제될경우, 카드테이블에서도 삭제 
or 카드 부터 지워야함)

- 연계통장을 선택 -> 연계통장이름을 가진 계좌번호를 BANK테이블에서 찾아서 CARD테이블에 C_account에 저장

- 체크박스 언체크시, 결제일이 Enable = false 라 공백 란이 들어감 	