# ui nginx启动脚本

html_dir=/var/www/html
index_file="${html_dir}/index.html"
index_file2="${html_dir}/index2.html"
envsubst < "${index_file}" > "${index_file2}"
rm $index_file
mv $index_file2 $index_file
nginx -g 'daemon off;'