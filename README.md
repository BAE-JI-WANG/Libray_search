# 수정 중
# 공공도서관 통합 어플리케이션 
## Public Library

### 메인 페이지
<p align="center">
  <img src='https://user-images.githubusercontent.com/59479926/154795798-21eb8a55-1483-4d90-8613-b2b88d8527ec.jpg', width=70%> 
  <!--  메인  -->
</p>

- 인기 장르 순위
- 장르별 도서 인기순위
- 도서 클릭시 상세정보 제공
- 도서 검색 기능
<br/>

### 상세정보 페이지

<p align="center">
  <img src='https://user-images.githubusercontent.com/59479926/154794207-47da0f95-cd75-4f27-b4da-c0a1cdc4f026.png', width=40%> 
  <!--  도서검색  -->
</p>

- 메인페이지에서 클릭한 도서의 상세정보 제공
- 검색을 통한 도서의 상세정보 제공
- 도서 구매 정보 링크 제공
<br/>

### 회원정보 페이지

<p align="center">
  <img src='https://user-images.githubusercontent.com/59479926/154794541-7a7757dc-544d-49e6-b743-320bf24e0009.png', width=25%> 
  <!--  도서대여  -->
</p>

- 회원정보 수정
- 도서의 반납, 대여 기간 연장
- 대여 도서의 목록
<br/>

### 도서관 검색 
<p align="center">
  <img src='https://user-images.githubusercontent.com/59479926/154794585-d3c8e39f-8df8-46fe-b0c2-be02010f6a55.png', width=25%> 
  <!--  도서관 검색  -->
</p>
## Why need this project

<p align="center">
    <img src='./image/capture.jpg', width=30%>
    <img src='./image/capture2.jpg', width=30%>
    <br>
    나도 모르게 찍게 되는 타인의 초상권, 프라이버시를 보호합시다.
</p>
## Requirements
- python 3
- Pillow
- face_recognition
- pickle
- opencv-contrib-python 3.4.0.14
- dlib

## Usage  

First, install libs

    pip install opencv-contrib-python==3.4.0.14
    pip install dlib
    pip install face_recognition
    pip install pickle
    pip install pillow


**Just run!** <br>

    python main.py
