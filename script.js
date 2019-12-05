use serials
db.docs.insertMany([
{
	"title" : "Побег",
	"country" : "Россия",
	"genre" : "Триллер",
	"ageLimits" : "18", //int
	"startDate" : new Date("2016-05-18"), //date
	"releaseDate" : new Date("2017-05-18"), //date
	"rating" : 8.5, //float
	"trailer" : "pobeg.rf/trailer",
	"studio" : "20th Century Fox"
},
{
	"title" : "Игра престолов",
	"country" : "США",
	"genre" : "Фентези",
	"ageLimits" : "16", //int
	"startDate" : new Date("2009-05-18"), //date
	"releaseDate" : new Date("2011-05-18"), //date
	"rating" : 9.6, //float
	"trailer" : "ip.com/trailer",
	"studio" : "HBO"
},
{
	"title" : "Шерлок",
	"country" : "Великобритания",
	"genre" : "Детектив",
	"ageLimits" : "12", //int
	"startDate" : new Date("2008-05-18"), //date
	"releaseDate" : new Date("2010-05-18"), //date
	"rating" : 8.7, //float
	"trailer" : "sherlock.com/trailer",
	"studio" : "Paramount Studio"
},
{
	"title" : "Во все тяжкие",
	"country" : "США",
	"genre" : "Триллер",
	"ageLimits" : "18", //int
	"startDate" : new Date("2012-05-18"), //date
	"releaseDate" : new Date("2013-05-18"), //date
	"rating" : 9.1, //float
	"trailer" : "brba.com/trailer",
	"studio" : "Warner Bros. Pictures"
},
{
	"title" : "Друзья",
	"country" : "США",
	"genre" : "Комедия",
	"ageLimits" : "16", //int
	"startDate" : new Date("2003-05-18"), //date
	"releaseDate" : new Date("2011-05-18"), //date
	"rating" : 7.2, //float
	"trailer" : "friends.com/trailer",
	"studio" : "Universal Studios"
},
{
	"title" : "Бюро легенд",
	"country" : "Франция",
	"genre" : "Драма",
	"ageLimits" : "18", //int
	"startDate" : new Date("2015-05-18"), //date
	"releaseDate" : new Date("2019-05-18"), //date
	"rating" : 6.1, //float
	"trailer" : "byuro.com/trailer",
	"studio" : "Universal Studios"
}
])