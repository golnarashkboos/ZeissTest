using System;
using System.Configuration;
using WebSocketSharp;
using ZeissTest.Business.Dto;
using ZeissTest.Business.IService;

namespace ZeissTest.WebApi.Listener
{
    public class MachineWebSocketListener
    {
        private readonly IMachineWebSocketService _machineWebSocketService;

        private const string WebSocketAddressConfigName = "WebSocketAddress";

        public MachineWebSocketListener(IMachineWebSocketService machineWebSocketService)
        {
            _machineWebSocketService = machineWebSocketService;
        }

        private void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            _machineWebSocketService.RecieveData(Newtonsoft.Json.JsonConvert.DeserializeObject<MachineWebSocketDto>(e.Data));
        }

        internal void Start()
        {
            var ws = new WebSocket(ConfigurationManager.AppSettings[WebSocketAddressConfigName]);

            ws.OnMessage += Ws_OnMessage;

            ws.Connect();
        }
    }
}