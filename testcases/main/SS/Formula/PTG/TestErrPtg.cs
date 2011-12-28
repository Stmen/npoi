/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

namespace NPOI.SS.Formula.PTG
{
    using System;
    using NPOI.HSSF.UserModel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NPOI.SS.UserModel;

    /**
     * Tests for {@link ErrPtg}.
     *
     * @author Daniel Noll (daniel at nuix dot com dot au)
     */
    [TestClass]
    public class TestErrPtg : AbstractPtgTestCase
    {
        /**
         * Tests Reading a file Containing this ptg.
         */
        [TestMethod]
        public void TestReading()
        {
            HSSFWorkbook workbook = LoadWorkbook("ErrPtg.xls");
            ICell cell = workbook.GetSheetAt(0).GetRow(3).GetCell(0);
            Assert.AreEqual(4.0, cell.NumericCellValue, 0.0, "Wrong cell value");
            Assert.AreEqual("ERROR.TYPE(#REF!)", cell.CellFormula, "Wrong cell formula");
        }
    }

}