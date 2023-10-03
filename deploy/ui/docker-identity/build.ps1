docker build -t util.platform.ui.identity:v1 .
docker run --name util.platform.ui.identity -d -p 16003:80 util.platform.ui.identity:v1