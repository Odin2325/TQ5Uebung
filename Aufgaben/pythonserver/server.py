import http.server
import socketserver

PORT = 8000

# class MyHandler(http.server.BaseHTTPRequestHandler):
#     def do_GET(self):
#         print(self.raw_requestline)
    
with socketserver.TCPServer(("", PORT), http.server.SimpleHTTPRequestHandler) as httpd:
    print("serving at port", PORT)
    httpd.serve_forever()