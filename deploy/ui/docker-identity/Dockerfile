# UI模块镜像配置

# nginx镜像作为基础镜像
FROM nginx:stable-alpine3.17

# 设置工作目录
WORKDIR /var/www/html

# 复制权限管理
COPY dist ./

# 复制nginx配置
COPY ./nginx/default.conf /etc/nginx/conf.d/

# 暴露http端口
EXPOSE 80

# 启动nginx
ENTRYPOINT ["nginx", "-g", "daemon off;"]