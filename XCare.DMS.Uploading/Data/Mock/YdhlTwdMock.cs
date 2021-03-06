﻿using System;
using System.Collections.Generic;
using Bogus;
using XCare.DMS.Entity;

namespace XCare.DMS.Uploading.Data.Mock
{
    public class YdhlTwdMock
    {
        public static List<YdhlTwd> Mock(long zyh)
        {
            var xhs = new List<decimal> {1, 2, 3, 4, 5, 6};
            return new Faker<YdhlTwd>().StrictMode(false)
                .RuleFor(e => e.Id, Guid.NewGuid)
                .RuleFor(e => e.Zyh, zyh)
                .RuleFor(e => e.Dbcs, f => f.Random.Int(0, 10).ToString())
                .RuleFor(e => e.Xbcs, f => f.Random.Int(4, 10).ToString())
                .RuleFor(e => e.Prl, f => f.Random.Int(100, 3000).ToString())
                .RuleFor(e => e.Pcl, f => f.Random.Int(100, 3000).ToString())
                .RuleFor(e => e.Xy, f => f.Random.Int(65, 200).ToString())
                .RuleFor(e => e.Tz, f => f.Random.Int(45, 200).ToString())
                .RuleFor(e => e.Shts, f => f.Random.Int(0, 200).ToString())
                .RuleFor(e => e.Mb, f => f.Random.Int(20, 180))
                .RuleFor(e => e.Tw, f => f.Random.Int(35, 42))
                .RuleFor(e => e.Hx, f => f.Random.Int(20, 60))
                .RuleFor(e => e.Jwhtw, f => f.Random.Int(35, 38))
                .RuleFor(e => e.Qbqmb, f => f.Random.Int(50, 70))
                .RuleFor(e => e.Hxjhx, f => f.Random.Int(25, 50))
                .RuleFor(e => e.Ywgm, f => f.PickRandom(0, 1).ToString())
                .FinishWith((f, e) =>
                {
                    e.Xh = f.PickRandom(xhs);
                    xhs.Remove(e.Xh);
                }).Generate(6);
        }
    }
}