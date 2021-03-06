
/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License Is distributed on an "AS Is" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

namespace NPOI.HWPF.Model.IO
{
    using System;
    using System.IO;
    using System.Collections;


    public class HWPFFileSystem
    {
        Hashtable _streams = new Hashtable();

        public HWPFFileSystem()
        {
            _streams["WordDocument"] = new HWPFStream();
            _streams["1Table"] = new HWPFStream();
            _streams["Data"] = new HWPFStream();
        }

        public HWPFStream GetStream(String name)
        {
            return (HWPFStream)_streams[name];
        }

    }
}