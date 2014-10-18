all:
	javac -d bin src/*.java

go:
	java -cp bin Runner

