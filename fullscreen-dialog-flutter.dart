// Hàm khởi tạo hộp thoại full-screen
  void _showAlert(BuildContext context) {
    showGeneralDialog(
        context: context,
        barrierDismissible: true,
        barrierLabel: MaterialLocalizations.of(context)
            .modalBarrierDismissLabel,
        barrierColor: Colors.white,
        transitionDuration: const Duration(milliseconds: 200),
        pageBuilder: (BuildContext buildContext,
            Animation animation,
            Animation secondaryAnimation) {
          return Center(
            child:
            Container(
              width: MediaQuery.of(context).size.width - 10,
              height: MediaQuery.of(context).size.height -  80,
              padding: EdgeInsets.all(10),
              color: Colors.white,
              child: Column(
                children: [
                  Text("Chào mừng bạn đến với Non Nguyen Blog",
                      style: TextStyle(color: Colors.black, fontSize: 20)),
                  RaisedButton(
                    onPressed: () {
                      Navigator.of(context).pop();
                    },
                    child: Text(
                      "Đóng lại",
                      style: TextStyle(color: Colors.white),
                    ),
                    color: Colors.blue,
                  )
                ],
              ),
            ),
          );
        });
  }

// Ví dụ gọi hàm
_showAlert(context);
