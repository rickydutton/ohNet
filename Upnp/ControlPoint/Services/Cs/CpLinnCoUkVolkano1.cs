using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Zapp.Core;
using Zapp.ControlPoint;

namespace Zapp.ControlPoint.Proxies
{
    public interface ICpProxyLinnCoUkVolkano1 : ICpProxy, IDisposable
    {
        void SyncReboot();
        void BeginReboot(CpProxy.CallbackAsyncComplete aCallback);
        void EndReboot(IntPtr aAsyncHandle);
        void SyncBootMode(out String aMode);
        void BeginBootMode(CpProxy.CallbackAsyncComplete aCallback);
        void EndBootMode(IntPtr aAsyncHandle, out String aMode);
        void SyncSetBootMode(String aMode);
        void BeginSetBootMode(String aMode, CpProxy.CallbackAsyncComplete aCallback);
        void EndSetBootMode(IntPtr aAsyncHandle);
        void SyncBspType(out String aBspType);
        void BeginBspType(CpProxy.CallbackAsyncComplete aCallback);
        void EndBspType(IntPtr aAsyncHandle, out String aBspType);
        void SyncUglyName(out String aUglyName);
        void BeginUglyName(CpProxy.CallbackAsyncComplete aCallback);
        void EndUglyName(IntPtr aAsyncHandle, out String aUglyName);
        void SyncMacAddress(out String aMacAddress);
        void BeginMacAddress(CpProxy.CallbackAsyncComplete aCallback);
        void EndMacAddress(IntPtr aAsyncHandle, out String aMacAddress);
        void SyncProductId(out String aProductNumber);
        void BeginProductId(CpProxy.CallbackAsyncComplete aCallback);
        void EndProductId(IntPtr aAsyncHandle, out String aProductNumber);
        void SyncBoardId(uint aIndex, out String aBoardNumber);
        void BeginBoardId(uint aIndex, CpProxy.CallbackAsyncComplete aCallback);
        void EndBoardId(IntPtr aAsyncHandle, out String aBoardNumber);
        void SyncBoardType(uint aIndex, out String aBoardNumber);
        void BeginBoardType(uint aIndex, CpProxy.CallbackAsyncComplete aCallback);
        void EndBoardType(IntPtr aAsyncHandle, out String aBoardNumber);
        void SyncMaxBoards(out uint aMaxBoards);
        void BeginMaxBoards(CpProxy.CallbackAsyncComplete aCallback);
        void EndMaxBoards(IntPtr aAsyncHandle, out uint aMaxBoards);
        void SyncSoftwareVersion(out String aSoftwareVersion);
        void BeginSoftwareVersion(CpProxy.CallbackAsyncComplete aCallback);
        void EndSoftwareVersion(IntPtr aAsyncHandle, out String aSoftwareVersion);
    }

    internal class SyncRebootLinnCoUkVolkano1 : SyncProxyAction
    {
        private CpProxyLinnCoUkVolkano1 iService;

        public SyncRebootLinnCoUkVolkano1(CpProxyLinnCoUkVolkano1 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndReboot(aAsyncHandle);
        }
    };

    internal class SyncBootModeLinnCoUkVolkano1 : SyncProxyAction
    {
        private CpProxyLinnCoUkVolkano1 iService;
        private String iMode;

        public SyncBootModeLinnCoUkVolkano1(CpProxyLinnCoUkVolkano1 aProxy)
        {
            iService = aProxy;
        }
        public String Mode()
        {
            return iMode;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndBootMode(aAsyncHandle, out iMode);
        }
    };

    internal class SyncSetBootModeLinnCoUkVolkano1 : SyncProxyAction
    {
        private CpProxyLinnCoUkVolkano1 iService;

        public SyncSetBootModeLinnCoUkVolkano1(CpProxyLinnCoUkVolkano1 aProxy)
        {
            iService = aProxy;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndSetBootMode(aAsyncHandle);
        }
    };

    internal class SyncBspTypeLinnCoUkVolkano1 : SyncProxyAction
    {
        private CpProxyLinnCoUkVolkano1 iService;
        private String iBspType;

        public SyncBspTypeLinnCoUkVolkano1(CpProxyLinnCoUkVolkano1 aProxy)
        {
            iService = aProxy;
        }
        public String BspType()
        {
            return iBspType;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndBspType(aAsyncHandle, out iBspType);
        }
    };

    internal class SyncUglyNameLinnCoUkVolkano1 : SyncProxyAction
    {
        private CpProxyLinnCoUkVolkano1 iService;
        private String iUglyName;

        public SyncUglyNameLinnCoUkVolkano1(CpProxyLinnCoUkVolkano1 aProxy)
        {
            iService = aProxy;
        }
        public String UglyName()
        {
            return iUglyName;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndUglyName(aAsyncHandle, out iUglyName);
        }
    };

    internal class SyncMacAddressLinnCoUkVolkano1 : SyncProxyAction
    {
        private CpProxyLinnCoUkVolkano1 iService;
        private String iMacAddress;

        public SyncMacAddressLinnCoUkVolkano1(CpProxyLinnCoUkVolkano1 aProxy)
        {
            iService = aProxy;
        }
        public String MacAddress()
        {
            return iMacAddress;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndMacAddress(aAsyncHandle, out iMacAddress);
        }
    };

    internal class SyncProductIdLinnCoUkVolkano1 : SyncProxyAction
    {
        private CpProxyLinnCoUkVolkano1 iService;
        private String iProductNumber;

        public SyncProductIdLinnCoUkVolkano1(CpProxyLinnCoUkVolkano1 aProxy)
        {
            iService = aProxy;
        }
        public String ProductNumber()
        {
            return iProductNumber;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndProductId(aAsyncHandle, out iProductNumber);
        }
    };

    internal class SyncBoardIdLinnCoUkVolkano1 : SyncProxyAction
    {
        private CpProxyLinnCoUkVolkano1 iService;
        private String iBoardNumber;

        public SyncBoardIdLinnCoUkVolkano1(CpProxyLinnCoUkVolkano1 aProxy)
        {
            iService = aProxy;
        }
        public String BoardNumber()
        {
            return iBoardNumber;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndBoardId(aAsyncHandle, out iBoardNumber);
        }
    };

    internal class SyncBoardTypeLinnCoUkVolkano1 : SyncProxyAction
    {
        private CpProxyLinnCoUkVolkano1 iService;
        private String iBoardNumber;

        public SyncBoardTypeLinnCoUkVolkano1(CpProxyLinnCoUkVolkano1 aProxy)
        {
            iService = aProxy;
        }
        public String BoardNumber()
        {
            return iBoardNumber;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndBoardType(aAsyncHandle, out iBoardNumber);
        }
    };

    internal class SyncMaxBoardsLinnCoUkVolkano1 : SyncProxyAction
    {
        private CpProxyLinnCoUkVolkano1 iService;
        private uint iMaxBoards;

        public SyncMaxBoardsLinnCoUkVolkano1(CpProxyLinnCoUkVolkano1 aProxy)
        {
            iService = aProxy;
        }
        public uint MaxBoards()
        {
            return iMaxBoards;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndMaxBoards(aAsyncHandle, out iMaxBoards);
        }
    };

    internal class SyncSoftwareVersionLinnCoUkVolkano1 : SyncProxyAction
    {
        private CpProxyLinnCoUkVolkano1 iService;
        private String iSoftwareVersion;

        public SyncSoftwareVersionLinnCoUkVolkano1(CpProxyLinnCoUkVolkano1 aProxy)
        {
            iService = aProxy;
        }
        public String SoftwareVersion()
        {
            return iSoftwareVersion;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndSoftwareVersion(aAsyncHandle, out iSoftwareVersion);
        }
    };

    /// <summary>
    /// Proxy for the linn.co.uk:Volkano:1 UPnP service
    /// </summary>
    public class CpProxyLinnCoUkVolkano1 : CpProxy, IDisposable, ICpProxyLinnCoUkVolkano1
    {
        private Zapp.Core.Action iActionReboot;
        private Zapp.Core.Action iActionBootMode;
        private Zapp.Core.Action iActionSetBootMode;
        private Zapp.Core.Action iActionBspType;
        private Zapp.Core.Action iActionUglyName;
        private Zapp.Core.Action iActionMacAddress;
        private Zapp.Core.Action iActionProductId;
        private Zapp.Core.Action iActionBoardId;
        private Zapp.Core.Action iActionBoardType;
        private Zapp.Core.Action iActionMaxBoards;
        private Zapp.Core.Action iActionSoftwareVersion;
        private Mutex iPropertyLock;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <remarks>Use CpProxy::[Un]Subscribe() to enable/disable querying of state variable and reporting of their changes.</remarks>
        /// <param name="aDevice">The device to use</param>
        public CpProxyLinnCoUkVolkano1(CpDevice aDevice)
            : base("linn-co-uk", "Volkano", 1, aDevice)
        {
            Zapp.Core.Parameter param;
            List<String> allowedValues = new List<String>();

            iActionReboot = new Zapp.Core.Action("Reboot");

            iActionBootMode = new Zapp.Core.Action("BootMode");
            allowedValues.Add("Main");
            allowedValues.Add("Fallback");
            allowedValues.Add("Ram");
            param = new ParameterString("aMode", allowedValues);
            iActionBootMode.AddOutputParameter(param);
            allowedValues.Clear();

            iActionSetBootMode = new Zapp.Core.Action("SetBootMode");
            allowedValues.Add("Main");
            allowedValues.Add("Fallback");
            param = new ParameterString("aMode", allowedValues);
            iActionSetBootMode.AddInputParameter(param);
            allowedValues.Clear();

            iActionBspType = new Zapp.Core.Action("BspType");
            param = new ParameterString("aBspType", allowedValues);
            iActionBspType.AddOutputParameter(param);

            iActionUglyName = new Zapp.Core.Action("UglyName");
            param = new ParameterString("aUglyName", allowedValues);
            iActionUglyName.AddOutputParameter(param);

            iActionMacAddress = new Zapp.Core.Action("MacAddress");
            param = new ParameterString("aMacAddress", allowedValues);
            iActionMacAddress.AddOutputParameter(param);

            iActionProductId = new Zapp.Core.Action("ProductId");
            param = new ParameterString("aProductNumber", allowedValues);
            iActionProductId.AddOutputParameter(param);

            iActionBoardId = new Zapp.Core.Action("BoardId");
            param = new ParameterUint("aIndex");
            iActionBoardId.AddInputParameter(param);
            param = new ParameterString("aBoardNumber", allowedValues);
            iActionBoardId.AddOutputParameter(param);

            iActionBoardType = new Zapp.Core.Action("BoardType");
            param = new ParameterUint("aIndex");
            iActionBoardType.AddInputParameter(param);
            param = new ParameterString("aBoardNumber", allowedValues);
            iActionBoardType.AddOutputParameter(param);

            iActionMaxBoards = new Zapp.Core.Action("MaxBoards");
            param = new ParameterUint("aMaxBoards");
            iActionMaxBoards.AddOutputParameter(param);

            iActionSoftwareVersion = new Zapp.Core.Action("SoftwareVersion");
            param = new ParameterString("aSoftwareVersion", allowedValues);
            iActionSoftwareVersion.AddOutputParameter(param);
            
            iPropertyLock = new Mutex();
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        public void SyncReboot()
        {
            SyncRebootLinnCoUkVolkano1 sync = new SyncRebootLinnCoUkVolkano1(this);
            BeginReboot(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndReboot().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginReboot(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionReboot, aCallback);
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndReboot(IntPtr aAsyncHandle)
        {
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aaMode"></param>
        public void SyncBootMode(out String aMode)
        {
            SyncBootModeLinnCoUkVolkano1 sync = new SyncBootModeLinnCoUkVolkano1(this);
            BeginBootMode(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aMode = sync.Mode();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndBootMode().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginBootMode(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionBootMode, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionBootMode.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aaMode"></param>
        public void EndBootMode(IntPtr aAsyncHandle, out String aMode)
        {
            uint index = 0;
            aMode = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aaMode"></param>
        public void SyncSetBootMode(String aMode)
        {
            SyncSetBootModeLinnCoUkVolkano1 sync = new SyncSetBootModeLinnCoUkVolkano1(this);
            BeginSetBootMode(aMode, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndSetBootMode().</remarks>
        /// <param name="aaMode"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginSetBootMode(String aMode, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionSetBootMode, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentString((ParameterString)iActionSetBootMode.InputParameter(inIndex++), aMode));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        public void EndSetBootMode(IntPtr aAsyncHandle)
        {
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aaBspType"></param>
        public void SyncBspType(out String aBspType)
        {
            SyncBspTypeLinnCoUkVolkano1 sync = new SyncBspTypeLinnCoUkVolkano1(this);
            BeginBspType(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aBspType = sync.BspType();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndBspType().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginBspType(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionBspType, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionBspType.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aaBspType"></param>
        public void EndBspType(IntPtr aAsyncHandle, out String aBspType)
        {
            uint index = 0;
            aBspType = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aaUglyName"></param>
        public void SyncUglyName(out String aUglyName)
        {
            SyncUglyNameLinnCoUkVolkano1 sync = new SyncUglyNameLinnCoUkVolkano1(this);
            BeginUglyName(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aUglyName = sync.UglyName();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndUglyName().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginUglyName(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionUglyName, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionUglyName.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aaUglyName"></param>
        public void EndUglyName(IntPtr aAsyncHandle, out String aUglyName)
        {
            uint index = 0;
            aUglyName = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aaMacAddress"></param>
        public void SyncMacAddress(out String aMacAddress)
        {
            SyncMacAddressLinnCoUkVolkano1 sync = new SyncMacAddressLinnCoUkVolkano1(this);
            BeginMacAddress(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aMacAddress = sync.MacAddress();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndMacAddress().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginMacAddress(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionMacAddress, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionMacAddress.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aaMacAddress"></param>
        public void EndMacAddress(IntPtr aAsyncHandle, out String aMacAddress)
        {
            uint index = 0;
            aMacAddress = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aaProductNumber"></param>
        public void SyncProductId(out String aProductNumber)
        {
            SyncProductIdLinnCoUkVolkano1 sync = new SyncProductIdLinnCoUkVolkano1(this);
            BeginProductId(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aProductNumber = sync.ProductNumber();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndProductId().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginProductId(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionProductId, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionProductId.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aaProductNumber"></param>
        public void EndProductId(IntPtr aAsyncHandle, out String aProductNumber)
        {
            uint index = 0;
            aProductNumber = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aaIndex"></param>
        /// <param name="aaBoardNumber"></param>
        public void SyncBoardId(uint aIndex, out String aBoardNumber)
        {
            SyncBoardIdLinnCoUkVolkano1 sync = new SyncBoardIdLinnCoUkVolkano1(this);
            BeginBoardId(aIndex, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aBoardNumber = sync.BoardNumber();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndBoardId().</remarks>
        /// <param name="aaIndex"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginBoardId(uint aIndex, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionBoardId, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionBoardId.InputParameter(inIndex++), aIndex));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionBoardId.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aaBoardNumber"></param>
        public void EndBoardId(IntPtr aAsyncHandle, out String aBoardNumber)
        {
            uint index = 0;
            aBoardNumber = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aaIndex"></param>
        /// <param name="aaBoardNumber"></param>
        public void SyncBoardType(uint aIndex, out String aBoardNumber)
        {
            SyncBoardTypeLinnCoUkVolkano1 sync = new SyncBoardTypeLinnCoUkVolkano1(this);
            BeginBoardType(aIndex, sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aBoardNumber = sync.BoardNumber();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndBoardType().</remarks>
        /// <param name="aaIndex"></param>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginBoardType(uint aIndex, CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionBoardType, aCallback);
            int inIndex = 0;
            invocation.AddInput(new ArgumentUint((ParameterUint)iActionBoardType.InputParameter(inIndex++), aIndex));
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionBoardType.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aaBoardNumber"></param>
        public void EndBoardType(IntPtr aAsyncHandle, out String aBoardNumber)
        {
            uint index = 0;
            aBoardNumber = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aaMaxBoards"></param>
        public void SyncMaxBoards(out uint aMaxBoards)
        {
            SyncMaxBoardsLinnCoUkVolkano1 sync = new SyncMaxBoardsLinnCoUkVolkano1(this);
            BeginMaxBoards(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aMaxBoards = sync.MaxBoards();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndMaxBoards().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginMaxBoards(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionMaxBoards, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentUint((ParameterUint)iActionMaxBoards.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aaMaxBoards"></param>
        public void EndMaxBoards(IntPtr aAsyncHandle, out uint aMaxBoards)
        {
            uint index = 0;
            aMaxBoards = Invocation.OutputUint(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aaSoftwareVersion"></param>
        public void SyncSoftwareVersion(out String aSoftwareVersion)
        {
            SyncSoftwareVersionLinnCoUkVolkano1 sync = new SyncSoftwareVersionLinnCoUkVolkano1(this);
            BeginSoftwareVersion(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aSoftwareVersion = sync.SoftwareVersion();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndSoftwareVersion().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginSoftwareVersion(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionSoftwareVersion, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionSoftwareVersion.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aaSoftwareVersion"></param>
        public void EndSoftwareVersion(IntPtr aAsyncHandle, out String aSoftwareVersion)
        {
            uint index = 0;
            aSoftwareVersion = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Must be called for each class instance.  Must be called before Core.Library.Close().
        /// </summary>
        public void Dispose()
        {
            DoDispose(true);
        }

        ~CpProxyLinnCoUkVolkano1()
        {
            DoDispose(false);
        }

        private void DoDispose(bool aDisposing)
        {
            lock (this)
            {
                if (iHandle == IntPtr.Zero)
                {
                    return;
                }
                DisposeProxy();
                iHandle = IntPtr.Zero;
                iActionReboot.Dispose();
                iActionBootMode.Dispose();
                iActionSetBootMode.Dispose();
                iActionBspType.Dispose();
                iActionUglyName.Dispose();
                iActionMacAddress.Dispose();
                iActionProductId.Dispose();
                iActionBoardId.Dispose();
                iActionBoardType.Dispose();
                iActionMaxBoards.Dispose();
                iActionSoftwareVersion.Dispose();
            }
            if (aDisposing)
            {
                GC.SuppressFinalize(this);
            }
        }
    }
}

