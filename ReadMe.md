# add-windows-default-path
## 사용 용도
윈도우 환경 변수 'Path' 항목에 'C:\Windows\system32'를 추가합니다. 

## 작동
배포된 `.exe` 파일을 다운로드합니다. 다운로드 한 파일을 관리자 권한으로 실행합니다. (이는 기본값입니다.)

이미 해당 변수가 존재하면 `! Path that already exists.`를 반환합니다. 정상적으로 작업이 완료될 경우 `success`를 반환합니다.

# add-windows-default-path
## purpose of use
Add 'C:\Windows\system32' to the Windows environment variable 'Path' item.

## work
Download the distributed `.exe` file. Run the downloaded file with administrator privileges. (This is the default.)

If the variable already exists, the `! Returns Path that already exists.` Returns `success` if the operation is successfully completed.