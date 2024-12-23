--
-- Indexes for dumped tables
--

--
-- Indexes for table tblbooknumber
--
ALTER TABLE tblbooknumber
  ADD PRIMARY KEY (ID);

--
-- Indexes for table tblbooks
--
ALTER TABLE tblbooks
  ADD PRIMARY KEY (BookID);

--
-- Indexes for table tblborrow
--
ALTER TABLE tblborrow
  ADD PRIMARY KEY (BorrowId);

--
-- Indexes for table tblborrower
--
ALTER TABLE tblborrower
  ADD PRIMARY KEY (IDNO),
  ADD UNIQUE KEY BorrowerId (BorrowerId);

--
-- Indexes for table tblcategory
--
ALTER TABLE tblcategory
  ADD PRIMARY KEY (CategoryId);

--
-- Indexes for table tbllogs
--
ALTER TABLE tbllogs
  ADD PRIMARY KEY (LogId);

--
-- Indexes for table tblpayment
--
ALTER TABLE tblpayment
  ADD PRIMARY KEY (PaymentId);

--
-- Indexes for table tblreturn
--
ALTER TABLE tblreturn
  ADD PRIMARY KEY (ReturnId);

--
-- Indexes for table tbluser
--
ALTER TABLE tbluser
  ADD PRIMARY KEY (UserId);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table tblbooknumber
--
ALTER TABLE tblbooknumber
  MODIFY ID int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table tblbooks
--
ALTER TABLE tblbooks
  MODIFY BookID int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table tblborrow
--
ALTER TABLE tblborrow
  MODIFY BorrowId int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table tblborrower
--
ALTER TABLE tblborrower
  MODIFY IDNO int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table tblcategory
--
ALTER TABLE tblcategory
  MODIFY CategoryId int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table tbllogs
--
ALTER TABLE tbllogs
  MODIFY LogId int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=483;

--
-- AUTO_INCREMENT for table tblpayment
--
ALTER TABLE tblpayment
  MODIFY PaymentId int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table tblreturn
--
ALTER TABLE tblreturn
  MODIFY ReturnId int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table tbluser
--
ALTER TABLE tbluser
  MODIFY UserId int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;
