class Stack:
	def __init__(self, max_size):
		self.top = -1
		self.max_size = max_size
		self.stack = [None for _ in range(max_size)]
	
	def is_full(self):
		return self.top == self.max_size
	
	def is_empty(self):
		return self.top == 0

	def push(self, val):
		self.top += 1
		if self.is_full() == True:
			raise FullExeption
		self.stack[self.top] = val

	def pop(self):
		if self.is_empty() == True:
			raise EmptyExeption    		
		res = self.stack[self.top]
		self.top -=1
	
		return res

class FullExeption(Exception):
    def __init__(self):
        super().__init__('Stack is full')

class EmptyExeption(Exception):
    	def __init__(self):
    		super().__init__('Stack is empty')

##########		
# Adaptor Design pattern: 이미 만들어진 것(pop)을 다시 재사용
class Stack2:
	def __init__(self):
		self.stack = []
	
	def push(self, num):
		self.stack.append(num)

	def pop(self):
		if self.isEmpty():
			raise Exception
		else:
			return self.stack.pop()

	def isEmpty(self):
		return len(self.stack) == 0
