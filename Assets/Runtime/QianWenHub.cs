/*************************************************************************
 *  Copyright (C) 2024 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  QianWenHub.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  2024/7/19
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.QianWen
{
    public class QianWenHub : IQianWenHub
    {
        protected string aipKey;

        public QianWenHub(string aipKey)
        {
            this.aipKey = aipKey;
        }

        public ITextDialog NewTextDialog(int timeOut = 60)
        {
            return new TextDialog(aipKey, timeOut);
        }
    }
}