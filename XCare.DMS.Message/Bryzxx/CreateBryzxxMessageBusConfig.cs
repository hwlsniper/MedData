﻿using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Bryzxx
{
    public class CreateBryzxxMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_bryzxx_create"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> SetReceiveEndPointHandle
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<CreateBryzxxMessageConsumer>(); });
                    };
            }
        }
    }
}